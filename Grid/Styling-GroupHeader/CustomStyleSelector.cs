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
    public class CustomStyleSelector : StyleSelector
    {
        public Style ExpandedStyle
        {
            get;
            set;
        }
        public Style CollapsedStyle
        {
            get;
            set;
        }
        protected override Style SelectStyleCore(object item, DependencyObject container)
        {
            if ((item as GroupHeaderContext).IsExpanded == true)
            {
                return this.ExpandedStyle;
            }
            else
            {
                return this.CollapsedStyle;
            }

        }
    }
}
