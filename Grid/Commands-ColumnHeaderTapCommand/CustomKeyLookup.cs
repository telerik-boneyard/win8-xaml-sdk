using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;

namespace Commands_ColumnHeaderTapCommand
{
    public class CustomIKeyLookup : IKeyLookup
    {
        public string GroupHeaderName { get; set; }

        public object GetKey(object instance)
        {
            if (this.GroupHeaderName == "Team")
            {
                return (instance as CustomData).Team.Length;
            }
            else if (this.GroupHeaderName == "GroundCapacity")
            {
                return (instance as CustomData).GroundCapacity;
            }
            else
            {
                return null;
            }


        }
    }
}
