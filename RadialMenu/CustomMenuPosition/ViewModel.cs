using System.Collections.ObjectModel;

namespace CustomMenuPosition
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Images = new ObservableCollection<string>();
            for (var i = 1; i <= 11; i++)
            {
                this.Images.Add("ms-appx:///Images/" + i + ".png");
            }
        }

        public ObservableCollection<string> Images { get; set; }
    }
}