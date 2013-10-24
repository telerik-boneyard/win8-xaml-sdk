using Telerik.Core;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace SingleThumbMode
{
    public class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            this.RedComponent = new ColorComponent(ComponentColors.Red) { Value = 70 };
            this.GreenComponent = new ColorComponent(ComponentColors.Green) { Value = 190 };
            this.BlueComponent = new ColorComponent(ComponentColors.Blue) { Value = 220 };

            this.RedComponent.PropertyChanged += Component_PropertyChanged;
            this.GreenComponent.PropertyChanged += Component_PropertyChanged;
            this.BlueComponent.PropertyChanged += Component_PropertyChanged;
        }

        void Component_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            OnPropertyChanged("Color");
        }

        public SolidColorBrush Color
        {
            get
            {
                return new SolidColorBrush
                {
                    Color = new Color()
                    {
                        A = 255,
                        R = (byte)this.RedComponent.Value,
                        G = (byte)this.GreenComponent.Value,
                        B = (byte)this.BlueComponent.Value
                    }
                };
            }
        }

        public ColorComponent RedComponent { get; set; }

        public ColorComponent GreenComponent { get; set; }

        public ColorComponent BlueComponent { get; set; }
    }
}