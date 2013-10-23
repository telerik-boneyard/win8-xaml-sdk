using Telerik.UI.Xaml.Controls.Primitives;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace CustomTriggerBehavior
{
    public class CustomTriggerBehavior : RadialMenuTriggerBehavior
    {
        public CustomTriggerBehavior()
        {
            this.AttachTriggers = RadialMenuAttachTriggers.None;
        }

        protected override void SubscribeToTargetEvents(FrameworkElement element)
        {
            base.SubscribeToTargetEvents(element);

            var textBox = element as TextBox;
            textBox.TextChanged += TextBoxTextChanged;
            textBox.KeyDown += TextBoxKeyDown;
        }

        void TextBoxKeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Escape)
            {
                this.DetachFromTargetElement();
            }
        }

        void TextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            this.AttachToTargetElement();
        }

        protected override void UnsubscribeFromTargetEvents(FrameworkElement element)
        {
            var textBox = element as TextBox;
            textBox.TextChanged -= TextBoxTextChanged;
            textBox.KeyDown -= TextBoxKeyDown;

            base.UnsubscribeFromTargetEvents(element);
        }
    }
}