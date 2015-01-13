using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Expander
{
    public class ExpanderControl : ContentControl
    {
        // Using a DependencyProperty as the backing store for Header.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(String), typeof(ExpanderControl), new PropertyMetadata(string.Empty));


        // Using a DependencyProperty as the backing store for IsExpander.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsExpanderProperty =
            DependencyProperty.Register("IsExpander", typeof(bool), typeof(ExpanderControl), new PropertyMetadata(false));



        public String Header
        {
            get
            {
                return (String)GetValue(HeaderProperty);
            }
            set
            {
                SetValue(HeaderProperty, value);
            }
        }


        public bool IsExpander
        {
            get 
            { 
                return (bool)GetValue(IsExpanderProperty); 
            }
            set 
            { 
                SetValue(IsExpanderProperty, value); 
            }
        }

        protected override Size MeasureOverride(Size availableSize)
        {

            return base.MeasureOverride(availableSize);
        }

    }
}
