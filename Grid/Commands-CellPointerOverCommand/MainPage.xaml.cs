using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using Telerik.UI.Xaml.Controls.Chart;
using Telerik.UI.Xaml.Controls.Grid;
using Telerik.UI.Xaml.Controls.Grid.Commands;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Commands_CellPointerOverCommand
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary> 
    public sealed partial class MainPage : Page
    {
        ViewModel viewmodel = new ViewModel();
        public MainPage()
        {
            this.InitializeComponent();
            
            this.DataContext = viewmodel;
            DataGridUserCommand command = new DataGridUserCommand() { Id = CommandId.CellPointerOver, Command = new CustomCommand(this.DataContext as ViewModel) };                                                                 
            dataGrid.Commands.Add(command);
          
             
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }


        private void DataGrid_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            viewmodel.SeriesSource = null;
        }
        
    }
}
