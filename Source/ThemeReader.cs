using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using VisualThemeEditor2012.Domain;

namespace VisualThemeEditor2012
{
    public static class ThemeReader
    {
        public const string RegPath = @"Software\Microsoft\VisualStudio\11.0_Config\Themes";

        public static IList<Theme> ReadThemes()
        {
            var themesReg = Registry.CurrentUser.OpenSubKey( RegPath );
            if( themesReg == null )
            {
                MessageBox.Show( "Error: Could not load registry path: "+ RegPath );
                return null;
            }
                
            var themesGuids = themesReg.GetSubKeyNames();

            if ( !themesGuids.Any() )
            {
                MessageBox.Show( "Could not find any themes." );
                return null;
            }

            var themes = new List<Theme>();

            foreach ( var g in themesGuids )
            {
                var themeReg = themesReg.OpenSubKey( g );

                var themeName = themeReg.GetValue("").ToString();

                var theme = new Theme() {Name = themeName, Guid = Guid.Parse( g )};
                themes.Add( theme );

                foreach( var catName in themeReg.GetSubKeyNames() )
                {
                    var categoryData = themeReg.OpenSubKey( catName ).GetValue( "Data" ) as byte[];
                    if( categoryData == null ) continue;

                    var category = UnpackColorCategory( categoryData);
                    category.Name = catName;
                    theme.Categories.Add( category );
                }

            }
            return themes;
        }

        private static Category UnpackColorCategory(byte[] data)
        {
            var category = new Category();

            using( var ms = new MemoryStream( data ) )
            using( var reader = new BinaryReader(ms))
            {
                category.Header = ms.ReadStruct<CategoryHeader>( );

                for( var i = 0; i < category.Header.ColorCount ; i++)
                {
                    var colorRecord = UnpackColorRecord( reader );
                    category.ColorRecords.Add( colorRecord );
                }
                //var alignCheck = reader.ReadInt32();
                //Debug.Assert( alignCheck == category.Header.CategoryDataSize, "The header (and color reads) alignment is not correct." );
            }
            return category;
        }

        private static ColorRecord UnpackColorRecord(BinaryReader reader)
        {
            var recordNameLen = reader.ReadInt32();
            var nameBytes = reader.ReadBytes( recordNameLen );

            var colorRecord = new ColorRecord
                {
                    Name = Encoding.UTF8.GetString( nameBytes ),
                };
            colorRecord.BackgroundPos = reader.BaseStream.Position;
            colorRecord.Background = UnpackColor( reader );
            colorRecord.ForegroundPos = reader.BaseStream.Position;
            colorRecord.Foreground = UnpackColor( reader );
            return colorRecord;
        }

        private static Color? UnpackColor(BinaryReader reader)
        {
            var hasValue = reader.ReadByte();
            if( hasValue == 0)
            {
                return null;
            }
            
            var r = reader.ReadByte();
            var g = reader.ReadByte();
            var b = reader.ReadByte();
            var a = reader.ReadByte();

            return Color.FromArgb( a, r, g, b );
        }
    }
    public static class ThemeWriter
    {
        public static void InjectColor(Color? fgColor, Color? bgColor, Theme theme, Category category, ColorRecord colorRec)
        {
            var regPath = Path.Combine( ThemeReader.RegPath, theme.Guid.ToString("B"), category.Name );
            var reg = Registry.CurrentUser.OpenSubKey( regPath, true );
            var colorData = reg.GetValue( "Data" ) as byte[];

            using( var ms = new MemoryStream( colorData ) )
            using( var bw = new BinaryWriter( ms))
            {
                if( bgColor != null )
                {
                    ms.Seek( colorRec.BackgroundPos, SeekOrigin.Begin );
                    WriteColor( bgColor.Value, bw );
                }
                if( fgColor != null)
                {
                    ms.Seek( colorRec.ForegroundPos, SeekOrigin.Begin );
                    WriteColor( fgColor.Value, bw );
                }

                bw.Flush();
                bw.Close();
                var setData = ms.ToArray();

                reg.SetValue( "Data", setData, RegistryValueKind.Binary );
            }
        }

        private static void WriteColor(Color color, BinaryWriter bw)
        {
            bw.Write( (byte)1 );
            bw.Write( color.R );
            bw.Write( color.G );
            bw.Write( color.B );
            bw.Write( color.A );
        }
    }
}