using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;

namespace Grouping_DelegateGroupDescriptor
{
    public class CustomIKeyLookup : IKeyLookup
    {
        public string TargetProperty { get; set; }

        public object GetKey(object instance)
        {
            if (this.TargetProperty == "City")
            {
                return (instance as DataClass).City[0];
            }
            else
            {
                return (instance as DataClass).Country[0];
            }
        }
    }
}
