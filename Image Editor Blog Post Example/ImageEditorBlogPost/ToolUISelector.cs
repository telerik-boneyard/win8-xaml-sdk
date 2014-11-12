using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;

namespace ImageEditorBlogPost
{
    public class ToolUISelector : ImageEditorToolUISelector
    {
        public DataTemplate SketchToolTemplate { get; set; }
        public override System.Windows.DataTemplate SelectTemplate(object tool, System.Windows.DependencyObject container)
        {
            if (tool is SketchTool)
            {
                return this.SketchToolTemplate;
            }

            return base.SelectTemplate(tool, container);
        }
    }
}
