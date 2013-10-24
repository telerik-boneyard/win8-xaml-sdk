using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;
using Telerik.UI.Xaml.Controls.Grid.Commands;

namespace Commands_GenerateColumnCommand
{
    public class CustomGenerateColumnCommand : DataGridCommand
    {
        public CustomGenerateColumnCommand()
        {
            this.Id = CommandId.GenerateColumn;
        }

        public override bool CanExecute(object parameter)
        {
            var context = parameter as GenerateColumnContext;
            if (context.PropertyName == "ID")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void Execute(object parameter)
        {
            var context = parameter as GenerateColumnContext;
            context.Result = new DataGridTextColumn();   
        }
    }
}