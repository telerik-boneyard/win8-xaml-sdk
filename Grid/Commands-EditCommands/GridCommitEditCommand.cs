using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid.Commands;
using Windows.UI.Popups;

namespace Commands_EditCommands
{
    public class GridCommitEditCommand : DataGridCommand
    {
        public GridCommitEditCommand()
        {
            this.Id = CommandId.CommitEdit;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public async override void Execute(object parameter)
        {
            MessageDialog dialog = new MessageDialog("Submit the changes?");
            bool? result = null;
            dialog.Commands.Add(
                new UICommand("OK", new UICommandInvokedHandler((cmd) => result = true)));
            dialog.Commands.Add(
                new UICommand("Cancel", new UICommandInvokedHandler((cmd) => result = false)));
            await dialog.ShowAsync();
            if (result == true)
            {
                this.Owner.CommandService.ExecuteDefaultCommand(CommandId.CommitEdit, parameter);
            }
        }
    }
}