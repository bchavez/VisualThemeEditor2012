using System;
using System.Collections.Generic;

namespace VisualThemeEditor2012.Domain
{
    public class Theme
    {
        public Theme()
        {
            this.Categories = new List<Category>();
        }

        public string Name { get; set; }
        public Guid Guid { get;set; }
        public List<Category> Categories { get; set; }
    }
}