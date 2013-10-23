using System.Linq;
using Telerik.Geospatial;
using Telerik.UI.Xaml.Controls.Map;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace RestrictPanningOnViewChangedCommand
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public void ChangeSelectedShape(object sender, SelectionChangedEventArgs e)
        {
            var textblock = (TextBlock)((sender as ListView).SelectedItems.FirstOrDefault(x => x is TextBlock));
            if (textblock != null)
            {
                if (textblock.Text == "Europe")
                {
                    SetEuropeView();
                }
                else
                {
                    SelectCountry(textblock.Text);
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void SetEuropeView()
        {
            if (this.radMap != null)
            {
                this.radMap.SetView(this.radMap.Layers[0].Bounds);
                var selectionBehavior = (MapShapeSelectionBehavior)this.radMap.Behaviors.FirstOrDefault(x => x is MapShapeSelectionBehavior);
                selectionBehavior.SelectedShape = null;
            }
        }

        private void SelectCountry(string country)
        {
            var layer = this.radMap.Layers.FirstOrDefault(x => x is MapShapeLayer);
            if (layer != null)
            {
                var shapes = (layer as MapShapeLayer).Source.Shapes;
                foreach (var shape in shapes)
                {
                    if (country == shape.GetAttribute("CNTRY_NAME").ToString())
                    {
                        var behavior = this.radMap.Behaviors.FirstOrDefault(x => x is MapShapeSelectionBehavior);
                        if (behavior != null)
                        {
                            (behavior as MapShapeSelectionBehavior).SelectedShape = shape;
                            var bounds = (shape as IMap2DShape).GetBounds();
                            this.radMap.SetView(bounds);
                            this.radMap.ZoomLevel -= 0.5;
                            break;
                        }
                    }
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