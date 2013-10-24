using Telerik.UI.Xaml.Controls.Primitives;
using Windows.Foundation;

namespace CustomMenuPosition
{
    public class CustomPositionTriggerBehavior : RadialMenuTriggerBehavior
    {
        public CustomPositionTriggerBehavior()
        {
            this.AttachTriggers = RadialMenuAttachTriggers.PointerOver;
        }

        protected override Windows.Foundation.Point GetMenuPosition(RadRadialMenu menu)
        {
            //get the left top point of the target element
            var targetPosition = this.Owner.TransformToVisual(null).TransformPoint(new Point(this.Owner.ActualWidth, 0));

            //calulate the desired menu position
            var position = new Point(targetPosition.X - menu.ActualWidth + this.Owner.ActualWidth / 2, targetPosition.Y + this.Owner.ActualHeight / 2 - menu.ActualHeight / 2);

            return position;
        }
    }
}