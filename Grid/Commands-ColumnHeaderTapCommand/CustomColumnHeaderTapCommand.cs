using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Data.Core;
using Telerik.UI.Xaml.Controls.Grid;
using Telerik.UI.Xaml.Controls.Grid.Commands;

namespace Commands_ColumnHeaderTapCommand
{
    class CustomColumnHeaderTapCommand : DataGridCommand
    {
        public CustomColumnHeaderTapCommand()
        {
            this.Id = CommandId.ColumnHeaderTap;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            base.Execute(parameter);
            ColumnHeaderTapContext context = parameter as ColumnHeaderTapContext;
            string columnHeader = context.Column.Header.ToString();
            RadDataGrid grid = this.Owner as RadDataGrid;
            if (context.Column.SortDirection == SortDirection.None)
            {
                grid.SortDescriptors.Clear();
                grid.SortDescriptors.Add(new DelegateSortDescriptor { KeyLookup = new CustomIKeyLookup() { GroupHeaderName = columnHeader }, SortOrder = SortOrder.Ascending });
                context.Column.SortDirection = SortDirection.Ascending;
            }
            else if (context.Column.SortDirection == SortDirection.Ascending)
            {
                grid.SortDescriptors.Clear();
                grid.SortDescriptors.Add(new DelegateSortDescriptor { KeyLookup = new CustomIKeyLookup() { GroupHeaderName = columnHeader }, SortOrder = SortOrder.Descending });
                context.Column.SortDirection = SortDirection.Descending;
            }
            else
            {
                grid.SortDescriptors.Clear();
                context.Column.SortDirection = SortDirection.None;
            }
        }
    }
}