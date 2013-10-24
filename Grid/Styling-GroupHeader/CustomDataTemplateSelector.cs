using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Styling_GroupHeader
{
    public class CustomDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ExpandedTemplate { get; set; }

        public DataTemplate CollapsedTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, Windows.UI.Xaml.DependencyObject container)
        {
            if ((item as GroupHeaderContext).IsExpanded == true)
            {
                return this.ExpandedTemplate;
            }
            else
            {
                return this.CollapsedTemplate;
            }
        }
    }
}