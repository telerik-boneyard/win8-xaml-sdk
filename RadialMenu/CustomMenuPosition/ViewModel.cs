using System.Collections.ObjectModel;

namespace CustomMenuPosition
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Images = new ObservableCollection<string>();
            for (var i = 1; i <= 4; i++)
            {
                this.Images.Add(string.Format("ms-appx:///Images/{0}.png", i));
            }
        }

        public ObservableCollection<string> Images { get; set; }
    }
}