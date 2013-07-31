using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Telerik.UI.Xaml.Controls.Grid;
using Telerik.UI.Xaml.Controls.Grid.Primitives;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Filtering_HowTo_CreateCustomFilteringControl
{
    public sealed partial class ContinentFilterControl : BaseFilterControl
    {
        public ContinentFilterControl()
        {
            this.InitializeComponent();
        }
        public override FilterDescriptorBase BuildDescriptor()
        {
            var descriptor = new BooleanFilterDescriptor() { PropertyName = this.PropertyName };
            descriptor.Value = checkBox.IsChecked;
            return descriptor;
        }

        protected override void Initialize()
        {
            var descriptor = this.AssociatedDescriptor as BooleanFilterDescriptor;
            if (descriptor != null)
            {
                this.checkBox.IsChecked = (bool?)descriptor.Value;
            }
        }
    }
}
