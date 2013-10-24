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

namespace Columns_CellContentTemplateSelector
{
    public class CustomObject
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

            List<CustomObject> list = new List<CustomObject>();
            list.Add(new CustomObject { Country = "Germany", Flag = new BitmapImage(new Uri("ms-appx:///Images/Germany.png", UriKind.Absolute)) });
            list.Add(new CustomObject { Country = "England", Flag = null });
            list.Add(new CustomObject { Country = "Mexico", Flag = new BitmapImage(new Uri("ms-appx:///Images/Mexico.png", UriKind.Absolute)) });
            list.Add(new CustomObject { Country = "Kenya", Flag = null });
            list.Add(new CustomObject { Country = "South-Africa", Flag = new BitmapImage(new Uri("ms-appx:///Images/South-Africa.png", UriKind.Absolute)) });
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