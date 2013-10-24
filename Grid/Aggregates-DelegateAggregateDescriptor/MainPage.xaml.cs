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

namespace Aggregates_DelegateAggregateDescriptor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ViewModel vm = new ViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = vm;
        }
        
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void RadDataGrid_DataBindingComplete(object sender, Telerik.UI.Xaml.Controls.Grid.DataBindingCompleteEventArgs e)
        {
            var currentView = (sender as RadDataGrid).GetDataView();
            if (currentView.Items.Count > 0)
            {
                vm.TotalSalary = (double)currentView.GetAggregateValue(0, null);
                vm.SalaryDifference = (double)currentView.GetAggregateValue(1, null);
            }
        }
    }
}