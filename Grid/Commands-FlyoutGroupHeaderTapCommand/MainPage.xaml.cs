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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Commands_FlyoutGroupHeaderTapCommand
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
            };
            this.grid.ItemsSource = data;
            this.grid.Commands.Add(new CustomFlyoutGroupHeaderTap() { CurrentGrid = this.grid });
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