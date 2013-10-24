using Telerik.UI.Xaml.Controls.Grid;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Filtering_HowTo_CreateCustomFilteringControl
{
    public sealed partial class ColorFilterControl : BaseFilterControl
    {
        private DelegateFilterDescriptor filterDescriptor;

        public ColorFilterControl(DelegateFilterDescriptor filterDescriptor)
        {
            this.InitializeComponent();
            this.filterDescriptor = filterDescriptor ?? new DelegateFilterDescriptor { Filter = new ColorFilter() };
            this.checkBoxContainer.ItemsSource = (this.filterDescriptor.Filter as ColorFilter).Colors;
        }

        public override FilterDescriptorBase BuildDescriptor()
        {
            return this.filterDescriptor;
        }

        protected override void Initialize()
        {
        }
    }
}