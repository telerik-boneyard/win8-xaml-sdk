using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Data.Core;

namespace Filtering_UsingDelegateFilterDescriptor
{
    
    public class CustomFilter : IFilter
    {
        public string CurrentFilter { get; set; }

        
        public bool PassesFilter(object item)
        {
            if ((item as CustomData).City.StartsWith(this.CurrentFilter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
