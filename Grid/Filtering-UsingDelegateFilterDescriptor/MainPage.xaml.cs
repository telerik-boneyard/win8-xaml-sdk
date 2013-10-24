using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Telerik.Data.Core;
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

namespace Filtering_UsingDelegateFilterDescriptor
{
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

        private void textbox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            CustomFilter updatedFilter = new CustomFilter();
            updatedFilter.CurrentFilter = (sender as TextBox).Text;
            if (this.dataGrid.FilterDescriptors.Count > 0)
            {
                this.dataGrid.FilterDescriptors.RemoveAt(0);
            }

            this.dataGrid.FilterDescriptors.Add(new DelegateFilterDescriptor { Filter = updatedFilter });
        }
    }
}