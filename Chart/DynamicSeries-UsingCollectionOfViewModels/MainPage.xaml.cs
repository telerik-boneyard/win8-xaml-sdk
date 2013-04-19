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

namespace DynamicSeries_UsingCollectionOfViewModels
{
   
     
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random r = new Random();
        public MainPage()
        {
            this.InitializeComponent();

            this.provider.Source = GenerateCollection();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        public List<CustomPoint> GenerateData()
        {
            List<CustomPoint> data = new List<CustomPoint>();
            data.Add(new CustomPoint { Category = "Apple", Value = r.Next(1, 20) });
            data.Add(new CustomPoint { Category = "Orange", Value = r.Next(10, 30) });
            data.Add(new CustomPoint { Category = "Lemon", Value = r.Next(20, 40) });
            return data;
        }
        public List<ViewModel> GenerateCollection()
        {
            List<ViewModel> collection = new List<ViewModel>();
            for (int i = 0; i < 5; i++)
            {
                ViewModel vm = new ViewModel();
                vm.GetData = GenerateData();
                collection.Add(vm);
            }
            return collection;
        }
       
      
    }
}
