using System.Linq;
using Telerik.Geospatial;
using Telerik.UI.Xaml.Controls.Map;

namespace RestrictPanningOnViewChangedCommand
{
    public class MapCoerceViewChangedCommand : MapCommand
    {
        public MapCoerceViewChangedCommand()
        {
            this.Id = CommandId.ViewChanged;
        }

        public override bool CanExecute(object parameter)
        {
            var context = parameter as ViewChangedContext;

            var selectionBehavior = (MapShapeSelectionBehavior)this.Owner.Behaviors.FirstOrDefault(x => x is MapShapeSelectionBehavior);
            if (selectionBehavior != null && selectionBehavior.SelectedShape != null && selectionBehavior.SelectedShape is IMap2DShape)
            {
                var shape = (IMap2DShape)selectionBehavior.SelectedShape;
                var shapeBounds = shape.GetBounds();

                var screenBounds = this.Owner.Bounds;

                var coercedCenter = CoerceLocation(context.NewCenter, screenBounds, shapeBounds);
                if (context.NewCenter != coercedCenter)
                {
                    context.NewCenter = coercedCenter;
                }

                return true;
            }

            return false;
        }

        public override void Execute(object parameter)
        {
            this.Owner.CommandService.ExecuteDefaultCommand(CommandId.ViewChanged, parameter);
        }

        private static Location CoerceLocation(Location locationToCoerce, LocationRect screenBounds, LocationRect shapeBounds)
        {
            if (locationToCoerce.Longitude < shapeBounds.East - (screenBounds.East - screenBounds.West) / 2)
            {
                locationToCoerce.Longitude = shapeBounds.East - (screenBounds.East - screenBounds.West) / 2;
            }
            else if (locationToCoerce.Longitude > shapeBounds.West + (screenBounds.East - screenBounds.West) / 2)
            {
                locationToCoerce.Longitude = shapeBounds.West + (screenBounds.East - screenBounds.West) / 2;
            }

            if (locationToCoerce.Latitude < shapeBounds.North - (screenBounds.North - screenBounds.South) / 2)
            {
                locationToCoerce.Latitude = shapeBounds.North - (screenBounds.North - screenBounds.South) / 2;
            }
            else if (locationToCoerce.Latitude > shapeBounds.South + (screenBounds.North - screenBounds.South) / 2)
            {
                locationToCoerce.Latitude = shapeBounds.South + (screenBounds.North - screenBounds.South) / 2;
            }

            return locationToCoerce;
        }
    }
}