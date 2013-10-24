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

namespace Grouping_DelegateGroupDescriptor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<DataClass> data = new List<DataClass>
            {
                new DataClass { Country = "Brazil", City = "Caxias do Sul" },
                new DataClass { Country = "Ghana", City = "Wa" },
                new DataClass { Country = "Brazil", City = "Fortaleza" },
                new DataClass { Country = "Italy", City = "Florence" },
                new DataClass { Country = "France", City = "Bordeaux" },
                new DataClass { Country = "Bulgaria", City = "Vratsa" },
                new DataClass { Country = "Spain", City = "Las Palmas" },
                new DataClass { Country = "France", City = "Le Mans" },
                new DataClass { Country = "Brazil", City = "Santos" },
                new DataClass { Country = "Ghana", City = "Ho" },
                new DataClass { Country = "Spain", City = "Malaga" },
                new DataClass { Country = "France", City = "Marseille" },
                new DataClass { Country = "Bulgaria", City = "Koynare" },
                new DataClass { Country = "Spain", City = "Valencia" },
                new DataClass { Country = "Ghana", City = "Kade" },
                new DataClass { Country = "Brazil", City = "Porto Alegre" },
                new DataClass { Country = "Bulgaria", City = "Byala Slatina" },
                new DataClass { Country = "Italy", City = "Naples" },
                new DataClass { Country = "Brazil", City = "Joinville" },
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

        private void Group_City_By_First_Letter(object sender, TappedRoutedEventArgs e)
        {
            this.grid.GroupDescriptors.Clear();
            this.grid.GroupDescriptors.Add(new DelegateGroupDescriptor() { KeyLookup = new CustomIKeyLookup() { TargetProperty = "City" } });
        }

        private void Group_Country_By_First_Letter(object sender, TappedRoutedEventArgs e)
        {
            this.grid.GroupDescriptors.Clear();
            this.grid.GroupDescriptors.Add(new DelegateGroupDescriptor() { KeyLookup = new CustomIKeyLookup() { TargetProperty = "Country" } });
        }

        private void Clear_Grouping(object sender, TappedRoutedEventArgs e)
        {
            this.grid.GroupDescriptors.Clear();
        }
    }
}