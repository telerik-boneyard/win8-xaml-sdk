using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;

namespace Sorting_UsingDelegateSortDescriptor
{
    public class CustomIKeyLookup : IKeyLookup
    {
        public object GetKey(object instance)
        {
            return (instance as CustomData).City.Length;
        }
    }
}
