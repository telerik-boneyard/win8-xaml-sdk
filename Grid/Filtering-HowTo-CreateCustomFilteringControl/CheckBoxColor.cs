using System.ComponentModel;

namespace Filtering_HowTo_CreateCustomFilteringControl
{
    public class CheckBoxColor : INotifyPropertyChanged
    {
        private bool isChecked;
        private EyeColor color;

        public event PropertyChangedEventHandler PropertyChanged;

        public EyeColor Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }
        
        public bool IsChecked
        {
            get
            {
                return this.isChecked;
            }
            set
            {
                if (this.isChecked != value)
                {
                    this.isChecked = value;
                    OnPropertyChanged("IsChecked");
                }
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}