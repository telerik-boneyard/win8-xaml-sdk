using Telerik.UI.Xaml.Controls.Grid;

namespace Columns_TemplateColumnSortDescriptor
{
    public class NameCustomKeyLoookup : IKeyLookup
    {
        public object GetKey(object instance)
        {
            return (instance as Data).LastName;
        }
    }
}