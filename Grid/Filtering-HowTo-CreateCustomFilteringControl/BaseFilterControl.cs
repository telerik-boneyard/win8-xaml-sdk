using Telerik.UI.Xaml.Controls.Grid;
using Telerik.UI.Xaml.Controls.Grid.Primitives;
using Windows.UI.Xaml.Controls;

namespace Filtering_HowTo_CreateCustomFilteringControl
{
    public abstract class BaseFilterControl : UserControl, IFilterControl
    {
        public string PropertyName { get; set; }

        public FilterDescriptorBase AssociatedDescriptor { get; set; }

        public bool IsFirst { get; set; }

        public abstract FilterDescriptorBase BuildDescriptor();

        protected abstract void Initialize();
    }
}