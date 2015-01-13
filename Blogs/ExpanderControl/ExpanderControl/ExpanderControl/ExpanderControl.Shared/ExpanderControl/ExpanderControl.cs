using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media.Animation;

namespace ExpanderControl
{
	//[TemplateVisualState(Name = ExpandedStateName, GroupName = ExpandStateGroupName)]
	//[TemplateVisualState(Name = CollapsedStateName, GroupName = ExpandStateGroupName)]
	public class ExpanderControl : ContentControl
	{
		// Using a DependencyProperty as the backing store for Header.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty HeaderProperty =
			DependencyProperty.Register("Header", typeof(object), typeof(ExpanderControl), new PropertyMetadata(null));

		// Using a DependencyProperty as the backing store for HeaderContentTemplate.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty HeaderContentTemplateProperty =
			DependencyProperty.Register("HeaderContentTemplate", typeof(object), typeof(ExpanderControl), new PropertyMetadata(null));


		// Using a DependencyProperty as the backing store for IsExpander.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsExpandedProperty =
			DependencyProperty.Register("IsExpanded", typeof(bool), typeof(ExpanderControl), new PropertyMetadata(false, OnIsExpandedChanged));

		//private const string ExpandedStateName = "Expanded";
		//private const string CollapsedStateName = "Collapsed";
		//private const string ExpandStateGroupName = "ExpandStateGroup";

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

		protected override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			//this.ChangeVisualState();
		}

		private static void OnIsExpandedChanged(DependencyObject sender, DependencyPropertyChangedEventArgs arg)
		{
			var expander = sender as ExpanderControl;
			//expander.ChangeVisualState();
		}

		//private void ChangeVisualState()
		//{
		//	if (this.IsExpanded)
		//	{

		//		VisualStateManager.GoToState(this, ExpandedStateName, false);
		//	}
		//	else
		//	{

		//		VisualStateManager.GoToState(this, CollapsedStateName, false);

		//	}
		//}
	}
}
