using System.Linq;
using Telerik.Geospatial;

namespace RestrictPanningOnViewChangedCommand
{
    public static class Extensions
    {
        public static LocationRect GetBounds(this IMap2DShape shape)
        {
            var minX = shape.Locations.Min(x => x.Min(y => y.Longitude));
            var minY = shape.Locations.Min(x => x.Min(y => y.Latitude));

            var maxX = shape.Locations.Max(x => x.Max(y => y.Longitude));
            var maxY = shape.Locations.Max(x => x.Max(y => y.Latitude));

            return new LocationRect(new Location(maxY, minX), new Location(minY, maxX));
        }
    }
}