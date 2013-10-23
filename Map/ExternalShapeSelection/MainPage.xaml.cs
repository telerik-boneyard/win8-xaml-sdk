using Telerik.Geospatial;
using Telerik.UI.Xaml.Controls.Map;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ExternalShapeSelection
{ 
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void SelectShape(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var country = (sender as Button).Content.ToString();
            var shapes = (this.radMap.Layers[0] as MapShapeLayer).Source.Shapes;
            foreach (var shape in shapes)
            {
                if (country == shape.GetAttribute("CNTRY_NAME").ToString())
                {
                    (this.radMap.Behaviors[0] as MapShapeSelectionBehavior).SelectedShape = shape;
                    break;
                }
            }
        }

        private void ShapefileDataSource_ShapeProcessingCompleted(object sender, System.EventArgs e)
        {
            var datasource = sender as IShapeDataSource;
            this.radMap.SetView(datasource.Shapes.BoundingRect);
        }
    }
}