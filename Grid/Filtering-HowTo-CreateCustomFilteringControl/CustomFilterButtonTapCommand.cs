using Telerik.UI.Xaml.Controls.Grid;
using Telerik.UI.Xaml.Controls.Grid.Commands;

namespace Filtering_HowTo_CreateCustomFilteringControl
{
    public class CustomFilterButtonTapCommand : DataGridCommand
    {
        public CustomFilterButtonTapCommand()
        {
            this.Id = CommandId.FilterButtonTap;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            var context = parameter as FilterButtonTapContext;
            if (ColumnMarker.GetRequiresCustomFiltering(context.Column))
            {
                context.FirstFilterControl = new ColorFilterControl(context.AssociatedDescriptor as DelegateFilterDescriptor)
                {
                    PropertyName = "EyeColor",
                    DataContext = context.AssociatedDescriptor
                };

                context.SecondFilterControl = null;

            }
            this.Owner.CommandService.ExecuteDefaultCommand(CommandId.FilterButtonTap, context);
        }
    }
}