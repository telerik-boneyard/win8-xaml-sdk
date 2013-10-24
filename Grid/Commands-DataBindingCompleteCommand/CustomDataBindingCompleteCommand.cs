using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;
using Telerik.UI.Xaml.Controls.Grid.Commands;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Commands_DataBindingCompleteCommand
{   
    public class CustomDataBindingCompleteCommand : DataGridCommand
    {
        public TextBlock Label { get; set; }
        public CustomDataBindingCompleteCommand()
        {
            this.Id = CommandId.DataBindingComplete;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override void Execute(object parameter)
        {
            var context = parameter as DataBindingCompleteEventArgs;
            if (context.ChangeFlags == DataChangeFlags.Source)
            {
                this.Label.Text = "DataGrid Source was loaded";
            }
            else
            {
                this.Label.Text = String.Format("{0}ing operation was executed", context.ChangeFlags);
            }
        }
    }
}
