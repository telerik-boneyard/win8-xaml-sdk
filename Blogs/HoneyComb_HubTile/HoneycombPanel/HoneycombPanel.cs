using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HoneycombPanel
{
	public class HoneycombPanel : Panel
	{
		private static readonly double COS_30_DEGREE = 0.866;
		protected override Size MeasureOverride(Size availableSize)
		{
			foreach (UIElement child in Children)
			{
				var tile = child as FrameworkElement;
				tile.Height = this.ItemLenght;
				tile.Width = (COS_30_DEGREE * this.ItemLenght / 2) * 2;
				tile.Measure(availableSize);
			}
			return base.MeasureOverride(availableSize);
		}
		protected override Size ArrangeOverride(Size finalSize)
		{
			int row, column;
			double x, y, height, width;

			for (int i = 0; i < this.Children.Count; i++)
			{
				height = this.Children[i].DesiredSize.Height;
				width = COS_30_DEGREE * height;
				row = HoneycombPanel.GetRow(this.Children[i]);
				column = HoneycombPanel.GetColumn(this.Children[i]);

				x = row % 2 == 0 ? column * width : (0.5 * width + column * width);
				y = 0.75 * row * height;

				this.Children[i].Arrange(new Rect(new Point(x, y), this.Children[i].DesiredSize));
			}

			return base.ArrangeOverride(finalSize);
		}
		public static readonly DependencyProperty ItemLenghtProperty =
			DependencyProperty.Register("ItemLenght", typeof(double), typeof(HoneycombPanel), null);
		public double ItemLenght
		{
			get { return (double)GetValue(ItemLenghtProperty); }
			set { SetValue(ItemLenghtProperty, value); }
		}
		public static readonly DependencyProperty RowProperty =
			DependencyProperty.RegisterAttached("Row", typeof(int), typeof(HoneycombPanel), null);
		public static int GetRow(DependencyObject obj)
		{
			return (int)obj.GetValue(RowProperty);
		}
		public static void SetRow(DependencyObject obj, int value)
		{
			obj.SetValue(RowProperty, value);
		}
		public static readonly DependencyProperty ColumnProperty =
			DependencyProperty.RegisterAttached("Column", typeof(int), typeof(HoneycombPanel), null);
		public static int GetColumn(DependencyObject obj)
		{
			return (int)obj.GetValue(ColumnProperty);
		}
		public static void SetColumn(DependencyObject obj, int value)
		{
			obj.SetValue(ColumnProperty, value);
		}
	}

}
