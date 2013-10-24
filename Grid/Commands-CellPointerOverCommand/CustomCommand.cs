using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Telerik.UI.Xaml.Controls.Chart;
using Telerik.UI.Xaml.Controls.Grid;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Commands_CellPointerOverCommand
{
    public class CustomCommand : ICommand
    {
        public ViewModel CurrentViewModel { get; set; }

        public CustomCommand(ViewModel currentViewModel)
        {
            this.CurrentViewModel = currentViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
        
        public void Execute(object parameter)
        {
            var currentItem = (parameter as DataGridCellInfo).Item as Data;
            this.CurrentViewModel.SeriesSource = currentItem.LastMatches;
            this.CurrentViewModel.ChartHeader = String.Format("Last 6 matches of {0}", currentItem.Team);
        }
    }
}