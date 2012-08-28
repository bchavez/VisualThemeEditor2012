using System.Drawing;
using System.Runtime.InteropServices;

namespace VisualThemeEditor2012.Domain
{
    public class ColorRecord
    {
        public string Name { get; set;}
        public Color? Foreground{ get;set; }
        public long ForegroundPos { get; set; }
        public Color? Background { get; set; }
        public long BackgroundPos { get; set; }
    }
}