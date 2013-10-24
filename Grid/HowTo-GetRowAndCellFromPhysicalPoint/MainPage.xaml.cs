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

namespace HowTo_GetRowAndCellFromPhysicalPoint
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<Data> dataList = new List<Data>();
            for (int i = 0; i < 4; i++)
            {
                dataList.Add(new Data { NumberString = i.ToString(), NumberInt = 1 });
            }
            DataGrid.ItemsSource = dataList;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void DataGrid_PointerMoved(object sender, PointerRoutedEventArgs e)
        {

            var physicalPoint = e.GetCurrentPoint(sender as RadDataGrid);
            var point = new Point { X = physicalPoint.Position.X, Y = physicalPoint.Position.Y };
            var row = (sender as RadDataGrid).HitTestService.RowItemFromPoint(point) as Data;
            var cell = (sender as RadDataGrid).HitTestService.CellInfoFromPoint(point) as DataGridCellInfo;
            if (row != null)
            {
                this.RowItem.Text = String.Format("Row : NumberString = {0}, NumberInt = {1}", row.NumberString, row.NumberInt);
                this.CellItem.Text = String.Format("Cell : {0} = {1}", cell.Column.Header, cell.Value);
            }
            else
            {
                this.RowItem.Text = "There is no Row Item";
                this.CellItem.Text = "There is no Cell Item";
            }
                
           

        }
        public class Data
        {
            public string NumberString { get; set; }

            public int NumberInt { get; set; }
        }
    }
}
