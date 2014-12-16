using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ExpanderControl
{
	public class ExpanderControl : ContentControl
	{
		public event EventHandler IsExpandedChanged;

		public static readonly DependencyProperty HeaderProperty =
			DependencyProperty.Register("Header", typeof(object), typeof(ExpanderControl), new PropertyMetadata(null));

		public static readonly DependencyProperty HeaderContentTemplateProperty =
			DependencyProperty.Register("HeaderContentTemplate", typeof(object), typeof(ExpanderControl), new PropertyMetadata(null));

		public static readonly DependencyProperty IsExpandedProperty =
			DependencyProperty.Register("IsExpanded", typeof(bool), typeof(ExpanderControl), new PropertyMetadata(false, OnIsExpandedChanged));

		public object Header
		{
			get
			{
				return (object)GetValue(HeaderProperty);
			}
			set
			{
				SetValue(HeaderProperty, value);
			}
		}

		public object HeaderContentTemplate
		{
			get
			{
				return (object)GetValue(HeaderContentTemplateProperty);
			}
			set
			{
				SetValue(HeaderContentTemplateProperty, value);
			}
		}

		public bool IsExpanded
		{
			get
			{
				return (bool)GetValue(IsExpandedProperty);
			}
			set
			{
				SetValue(IsExpandedProperty, value);
			}
		}
		
		private static void OnIsExpandedChanged(DependencyObject sender, DependencyPropertyChangedEventArgs arg)
		{
			var expander = sender as ExpanderControl;
			expander.RaiseIsExpandedChanged();
		}

		private void RaiseIsExpandedChanged()
		{
			EventHandler handler = IsExpandedChanged;
			if (handler != null)
			{
				handler(this, EventArgs.Empty);
			}
		}
	}
}
