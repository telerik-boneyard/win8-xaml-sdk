using Telerik.UI.Xaml.Controls.Grid;

namespace Columns_TemplateColumnGroupDescriptor
{
    public class NameCustomKeyLoookup : IKeyLookup
    {
        public object GetKey(object instance)
        {
            return (instance as Data).LastName[0];
        }
    }
}
