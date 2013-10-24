using Telerik.Core;

namespace SingleThumbMode
{
    public class ColorComponent : ViewModelBase
    {
        private byte componentValue;

        public ColorComponent(ComponentColors component)
        {
            this.Component = component;
        }

        public double Value
        {
            get
            {
                return this.componentValue;
            }
            set
            {
                var byteValue = (byte)value;
                if (this.componentValue != byteValue)
                {
                    componentValue = byteValue;
                    OnPropertyChanged();
                }
            }
        }

        public ComponentColors Component { get; set; }
    }
}