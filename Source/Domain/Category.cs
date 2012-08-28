using System.Collections.Generic;

namespace VisualThemeEditor2012.Domain
{
    public class Category
    {
        public Category()
        {
            this.ColorRecords = new List<ColorRecord>();
        }

        public string Name { get; set; }
        public List<ColorRecord> ColorRecords { get; set; }

        public CategoryHeader Header { get; set; }

    }
}