using Windows.UI.Xaml;

namespace Filtering_HowTo_CreateCustomFilteringControl
{
    public class ColumnMarker
    {
        public static bool GetRequiresCustomFiltering(DependencyObject obj)
        {
            return (bool)obj.GetValue(RequiresCustomFilteringProperty);
        }

        public static void SetRequiresCustomFiltering(DependencyObject obj, bool value)
        {
            obj.SetValue(RequiresCustomFilteringProperty, value);
        }

        // Using a DependencyProperty as the backing store for RequiresCustomFiltering.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RequiresCustomFilteringProperty =
            DependencyProperty.RegisterAttached("RequiresCustomFiltering", typeof(bool), typeof(ColumnMarker), new PropertyMetadata(false));
    }
}