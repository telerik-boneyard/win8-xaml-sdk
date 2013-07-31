using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;
using Telerik.UI.Xaml.Controls.Grid.Commands;

namespace Commands_FlyoutGroupHeaderTapCommand
{
    public class CustomFlyoutGroupHeaderTap : DataGridCommand
    {
        public RadDataGrid CurrentGrid { get; set; }

        public CustomFlyoutGroupHeaderTap()
        {
            this.Id = CommandId.FlyoutGroupHeaderTap;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            var context = parameter as FlyoutGroupHeaderTapContext;
            if (context.Action == DataGridFlyoutGroupHeaderTapAction.RemoveDescriptor)
            {
                if ((context.Descriptor as PropertyGroupDescriptor).PropertyName == "City")
                {
                    (this.Owner as RadDataGrid).GroupDescriptors.Remove(context.Descriptor);
                }
            }
        }
    }
}