using System;
using System.Collections.Generic;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Columns_AddTemplateColumn
{
    public class Data
    {
        public string Country { get; set; }

        public BitmapImage Flag { get; set; }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            List<Data> list = new List<Data>();
            list.Add(new Data { Country = "Argentina", Flag = new BitmapImage(new Uri("ms-appx:///Images/Argentina.png", UriKind.Absolute)) });
            list.Add(new Data { Country = "Brazil", Flag = new BitmapImage(new Uri("ms-appx:///Images/Brazil.png", UriKind.Absolute)) });
            list.Add(new Data { Country = "China", Flag = new BitmapImage(new Uri("ms-appx:///Images/China.png", UriKind.Absolute)) });
            this.grid.ItemsSource = list;
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