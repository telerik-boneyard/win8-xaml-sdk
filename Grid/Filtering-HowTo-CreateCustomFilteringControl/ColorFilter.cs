using System;
using System.Linq;
using System.Collections.ObjectModel;
using Telerik.Data.Core;

namespace Filtering_HowTo_CreateCustomFilteringControl
{
    public class ColorFilter : IFilter
    {
        private ObservableCollection<CheckBoxColor> colors;

        public ColorFilter() 
        {
            this.colors = new ObservableCollection<CheckBoxColor>();
            foreach (var color in Enum.GetValues(typeof(EyeColor)))
            {
                this.colors.Add(new CheckBoxColor { Color = (EyeColor)color, IsChecked = false });
            }
        }

        public ObservableCollection<CheckBoxColor> Colors
        {
            get
            {
                return colors;
            }
        }

        public bool PassesFilter(object item)
        {
            return colors.Where(x => x.Color == (item as Data).EyeColor).FirstOrDefault().IsChecked;
        }
    }
}