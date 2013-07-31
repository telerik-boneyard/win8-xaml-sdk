using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (context.Column.Header.ToString() == "Continent")
            {
                context.FirstFilterControl = new ContinentFilterControl() { PropertyName = "IsFromEurope" };
                context.SecondFilterControl = null;
                this.Owner.CommandService.ExecuteDefaultCommand(CommandId.FilterButtonTap, context);
            }
            else
            {
                this.Owner.CommandService.ExecuteDefaultCommand(CommandId.FilterButtonTap, context);
            }


        }
    }
}
