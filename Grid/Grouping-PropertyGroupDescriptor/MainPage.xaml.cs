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

namespace Grouping_PropertyGroupDescriptor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<Data> data = new List<Data>
                                     {

                                         new Data { Country = "Brazil", City = "Caxias do Sul"},
                                         new Data { Country = "Ghana", City = "Wa"},
                                         new Data { Country = "Brazil", City = "Fortaleza"},
                                         new Data { Country = "Italy", City = "Florence" },
                                         new Data { Country = "France", City = "Bordeaux" }, 
                                         new Data { Country = "Bulgaria", City = "Vratsa"},
                                         new Data { Country = "Spain", City = "Las Palmas"},
                                         new Data { Country = "France", City = "Le Mans" },
                                         new Data { Country = "Brazil", City = "Santos"},
                                         new Data { Country = "Ghana", City = "Ho"},
                                         new Data { Country = "Spain", City = "Malaga"},
                                         new Data { Country = "France", City = "Marseille" },
                                         new Data { Country = "Bulgaria", City = "Koynare" },  
                                         new Data { Country = "Spain", City = "Valencia"},
                                         new Data { Country = "Ghana", City = "Kade" },
                                         new Data { Country = "Brazil", City = "Porto Alegre" }, 
                                         new Data { Country = "Bulgaria", City = "Byala Slatina"},
                                         new Data { Country = "Italy", City = "Naples" },
                                         new Data { Country = "Brazil", City = "Joinville" }, 
                                     };
            this.grid.ItemsSource = data;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Group_by_Country(object sender, TappedRoutedEventArgs e)
        {
            this.grid.GroupDescriptors.Clear();
            this.grid.GroupDescriptors.Add(new PropertyGroupDescriptor(){ PropertyName = "Country"});
        }

        private void Group_by_City(object sender, TappedRoutedEventArgs e)
        {
             this.grid.GroupDescriptors.Clear();
             this.grid.GroupDescriptors.Add(new PropertyGroupDescriptor(){ PropertyName = "City"});
        }

        private void Clear_Grouping(object sender, TappedRoutedEventArgs e)
        {
            this.grid.GroupDescriptors.Clear();
        }
    }
}
