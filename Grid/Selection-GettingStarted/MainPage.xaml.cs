using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Telerik.UI.Xaml.Controls.Grid;
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

namespace Selection_GettingStarted
{
    
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
             
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void RadDataGrid_SelectionChanged_1(object sender, Telerik.UI.Xaml.Controls.Grid.DataGridSelectionChangedEventArgs e)
        {
            var grid = sender as RadDataGrid;
            var selectedItem = grid.SelectedItem as DataGridCellInfo;
            if (grid.SelectedItem != null)
            {
                textblock1.Text = String.Format("The selected item is {0}",selectedItem.Column.GetValueForInstance(selectedItem.Item).ToString());
                textblock2.Text = String.Format("The selected item is in the {0} column", selectedItem.Column.Header.ToString());
            }
        }
    }
}
