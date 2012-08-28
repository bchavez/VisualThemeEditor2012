using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using VisualThemeEditor2012.Domain;

namespace VisualThemeEditor2012
{
    public partial class frmMain : Form
    {
        private IList<Theme> themes;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown( object sender, System.EventArgs e )
        {
            themes = ThemeReader.ReadThemes();
            this.themeBindingSource.DataSource = themes;
        }

        private void themeBindingSource_PositionChanged( object sender, System.EventArgs e )
        {
            this.categoryBindingSource.DataSource = null;
            this.categoryBindingSource.DataSource = (this.themeBindingSource.Current as Theme).Categories;
            this.categoryBindingSource.MoveFirst();
        }

        private void categoryBindingSource_PositionChanged( object sender, System.EventArgs e )
        {
            this.colorRecordBindingSource.DataSource = (this.categoryBindingSource.Current as Category).ColorRecords;
            this.colorRecordBindingSource.MoveFirst();
        }

        private void colorRecordBindingSource_CurrentChanged( object sender, System.EventArgs e )
        {
            var selected = this.colorRecordBindingSource.Current as ColorRecord;
            this.cmdSaveColor.Enabled = false;
            if( selected.Foreground != null )
            {
                this.colorFG.BackColor = selected.Foreground.Value;
                this.colorFG.Enabled = true;
            }
            else
            {
                this.colorFG.BackColor = Color.Transparent;
                this.lblFG.Text = " -- No Color --";
                this.colorFG.Enabled = false;
            }

            if( selected.Background != null )
            {
                this.colorBG.BackColor = selected.Background.Value;
                this.colorBG.Enabled = true;
            }
            else
            {
                this.colorBG.BackColor = Color.Transparent;
                this.colorBG.Text = " -- No Color -- ";
                this.colorBG.Enabled = false;
            }
            this.lblRecord.Text = selected.Name;
        }

        private void cmdSaveColor_Click( object sender, System.EventArgs e )
        {
            var fgColor = this.colorFG.Enabled ? (Color?)this.colorFG.BackColor : null;
            var bgColor = this.colorBG.Enabled ? (Color?)this.colorBG.BackColor : null;

            var theme = this.themeBindingSource.Current as Theme;
            var category = this.categoryBindingSource.Current as Category;
            var record = this.colorRecordBindingSource.Current as ColorRecord;

            ThemeWriter.InjectColor( fgColor, bgColor, theme, category, record );
            this.cmdSaveColor.Enabled = false;
            record.Foreground = fgColor;
            record.Background = bgColor;
        }

        private void color_Click( object sender, System.EventArgs e )
        {
            var button = sender as Button;
            this.colorPicker.AllowFullOpen = true;
            this.colorPicker.FullOpen = true;
            this.colorPicker.AnyColor = true;

            this.colorPicker.Color = button.BackColor;

            if( this.colorPicker.ShowDialog() == DialogResult.OK )
            {
                button.BackColor = this.colorPicker.Color;

                this.cmdSaveColor.Enabled = true;
            }
        }

        private void colorFG_BackColorChanged( object sender, System.EventArgs e )
        {
            this.lblFG.Text = string.Format( "{0}, {1}, {2}", this.colorFG.BackColor.R, this.colorFG.BackColor.G, this.colorFG.BackColor.B );
        }

        private void colorBG_BackColorChanged( object sender, System.EventArgs e )
        {
            this.lblBG.Text = string.Format( "{0}, {1}, {2}", this.colorBG.BackColor.R, this.colorBG.BackColor.G, this.colorBG.BackColor.B );
        }

        private void lnkReset_Click( object sender, System.EventArgs e )
        {
            var theme = this.themeBindingSource.Current as Theme;

            Process.Start( "regedit.exe", "VS2012.Stock.Theme." + theme.Name + ".reg" )
                .WaitForExit();

            var newThemes = ThemeReader.ReadThemes();
            this.themeBindingSource.DataSource = null;
            this.categoryBindingSource.DataSource = null;
            this.colorRecordBindingSource.DataSource = null;

            this.themeBindingSource.DataSource = newThemes;
        }

        private void ValidatingColor( object sender, System.ComponentModel.CancelEventArgs e )
        {
            //MessageBox.Show( "validating." );
            if( this.cmdSaveColor.Enabled )
            {
                if( MessageBox.Show( "Save last Color?", "Color", MessageBoxButtons.YesNo ) == DialogResult.Yes )
                {
                    this.cmdSaveColor_Click( null, null );
                }
                else
                {
                    this.cmdSaveColor.Enabled = false;
                }
            }
        }

        private void lstRecords_SelectedValueChanged( object sender, System.EventArgs e )
        {
            ValidatingColor( null, null );
        }

        private void cboCategory_SelectedValueChanged( object sender, System.EventArgs e )
        {
            ValidatingColor( null, null );
        }
    }
}
