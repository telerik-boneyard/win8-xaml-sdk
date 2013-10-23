using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
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

namespace CartesianChart_OhlcSeries
{
    public class FinancialData
    {
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
    }
    public class ViewModel
    {
        public ObservableCollection<FinancialData> GetData
        {
            get
            {
                ObservableCollection<FinancialData> collection = new ObservableCollection<FinancialData>();
                collection.Add(new FinancialData() { High = 10, Open = 5, Low = 2, Close = 8 });
                collection.Add(new FinancialData() { High = 15, Open = 7, Low = 3, Close = 5 });
                collection.Add(new FinancialData() { High = 20, Open = 15, Low = 10, Close = 19 });
                collection.Add(new FinancialData() { High = 7, Open = 2, Low = 1, Close = 5 });
                collection.Add(new FinancialData() { High = 25, Open = 15, Low = 10, Close = 12 });
                return collection;
            }
        }
    }
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
    }
}
