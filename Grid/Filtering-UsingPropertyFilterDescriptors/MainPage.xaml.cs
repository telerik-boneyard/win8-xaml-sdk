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

namespace Filtering_UsingPropertyFilterDescriptors
{
 
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.combobox.SelectedIndex = 5;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (sender as ComboBox).SelectedItem as ComboBoxItem;

            if ((selectedItem.Content as TextBlock).Text == "Clear Filtering")
            {
                this.grid.FilterDescriptors.Clear();
            }
            else
            {
                this.grid.FilterDescriptors.Clear();
                this.grid.FilterDescriptors.Add(selectedItem.Tag as FilterDescriptorBase);
            }
           
        }

    
    
       
    }
}
