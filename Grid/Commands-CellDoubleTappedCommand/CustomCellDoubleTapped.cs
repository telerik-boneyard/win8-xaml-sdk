using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Grid;
using Telerik.UI.Xaml.Controls.Grid.Commands;
using Windows.UI.Xaml.Controls;

namespace Commands_CellDoubleTappedCommand
{
     
    public class CustomCellDoubleTapped : DataGridCommand
    {
        public Frame CurrentFrame { get; set; }
        public CustomCellDoubleTapped()
        {
            this.Id = CommandId.CellDoubleTap;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override void Execute(object parameter)
        {
            (this.CurrentFrame as Frame).Navigate(typeof(DetailsPage), (parameter as DataGridCellInfo).Item as Data);
        }
    }
}
