using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Columns_CellContentStyleSelector
{
    public class CustomStyleSelector : StyleSelector
    {
        public Style PoorMarkStyle
        {
            get;
            set;
        }
        public Style ExcellentMarkStyle
        {
            get;
            set;
        }
        protected override Style SelectStyleCore(object item, DependencyObject container)
        {
            int mark = (int)((item as DataGridCellInfo).Item as CustomData).Mark;
            if (mark == 6)
            {
                return this.ExcellentMarkStyle;
            }
            else
            {
                return this.PoorMarkStyle;
            }
        }
    }
}
