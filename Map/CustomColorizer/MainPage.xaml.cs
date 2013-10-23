using Telerik.Geospatial;
using Telerik.UI.Xaml.Controls.Map;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CustomColorizer
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

        private void ShapefileDataSource_ShapeProcessingCompleted(object sender, System.EventArgs e)
        {
            var datasource = sender as IShapeDataSource;
            this.radMap.SetView(datasource.Shapes.BoundingRect);
        }
    }
}