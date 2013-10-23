using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Geospatial;
using Telerik.UI.Drawing;
using Telerik.UI.Xaml.Controls.Map;
using Windows.UI;

namespace CustomColorizer
{
    public class CustomColorizer : MapShapeColorizer
    {
        private double min;
        private double max;

        public CustomColorizer()
        {
            this.min = double.MaxValue;
            this.max = double.MinValue;
        }

        protected override D2DShapeStyle GetShapeStyle(IMapShape shape)
        {
            var populationDensity = GetPopulationDensity(shape);
            var color = GetColor(populationDensity);
            var style = new D2DShapeStyle
            {
                Fill = new D2DSolidColorBrush { Color = color },
                StrokeThickness = 0
            };
            return style;
        }

        protected override bool InitializeOverride(IEnumerable<IMapShape> shapes)
        {
            foreach (var shape in shapes)
            {
                var populationDensity = GetPopulationDensity(shape);
                this.min = Math.Min(this.min, populationDensity);
                this.max = Math.Max(this.max, populationDensity);
            }

            return true;
        }

        private double GetPopulationDensity(IMapShape shape)
        {
            var population = int.Parse(shape.GetAttribute("POP_CNTRY").ToString());
            if (population < 0)
                return 0;
            var area = double.Parse(shape.GetAttribute("SQKM").ToString());
            var density = population / area;

            return density;
        }

        private Color GetColor(double density)
        {
            if (density < 2)
            {
                return Color.FromArgb(255, 250, 250, 250);
            }
            
            if (density < 10)
            {
                return Colors.Lime;
            }
           
            if (density < 50)
            {
                return Colors.Yellow;
            }
            
            if (density < 100)
            {
                return Colors.Orange;
            }
            return Colors.Tomato;
        }
        
        protected override void ResetOverride()
        {
        }
    }
}