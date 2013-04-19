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

namespace CartesianChart_ScatterSeries
{
    public class Data
    {
        public double XValue
        {
            get;
            set;
        }
        public double YValue
        {
            get;
            set;
        }
    }
    public class ViewModel
    {

        public ObservableCollection<Data> GetData
        {
            get
            {
                ObservableCollection<Data> collection = new ObservableCollection<Data>();
                collection.Add(new Data { XValue = 2, YValue = 3 });
                collection.Add(new Data { XValue = 5, YValue = 6 });
                collection.Add(new Data { XValue = 8, YValue = 3 });
                collection.Add(new Data { XValue = 10, YValue = 5 });
                collection.Add(new Data { XValue = 14, YValue = 1 });
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
