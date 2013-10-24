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

namespace Decorations_GettingStarted
{
    public class Data
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }
    }

    public class ViewModel
    {
        public List<Data> DataGrid { get; set; }

        public ViewModel()
        {
            DataGrid = CreateData();
        }

        public List<Data> CreateData()
        {
            List<Data> list = new List<Data>();
            list.Add(new Data { Name = "Pirkko Koskitalo", Title = "Accounting Manager", Country = "Finland", Address = "Torikatu 38" });
            list.Add(new Data { Name = "Antonio Moreno", Title = "Owner", Country = "Mexico", Address = "Mataderos 2312" });
            list.Add(new Data { Name = "Ann Devon", Title = "Sales Agent", Country = "UK", Address = "35 King George" });
            list.Add(new Data { Name = "Hanna Moos", Title = "Sales Representive", Country = "Germany", Address = "Forsterstr. 57" });
            list.Add(new Data { Name = "Georg Pipps", Title = "Sales Manager", Country = "Austria", Address = "Geislweg 14" });
            list.Add(new Data { Name = "Paolo Accorti", Title = "Sales Representive", Country = "Italy", Address = "Via Monte Bianco 34" });
            list.Add(new Data { Name = "Sergio Gutierrez", Title = "Sales Representive", Country = "Argentina", Address = "Al. del Libertador 900" });
            list.Add(new Data { Name = "Michael Holz", Title = "Sales Manager", Country = "Switzerland", Address = "Grenzacherweg 237" });
            return list;
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