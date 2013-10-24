using System.Collections.ObjectModel;

namespace Filtering_HowTo_CreateCustomFilteringControl
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Data = new ObservableCollection<Data>()
            {
                new Data { Name = "Peter", EyeColor = EyeColor.Black },
                new Data { Name = "Erik", EyeColor = EyeColor.Green },
                new Data { Name = "Smith", EyeColor = EyeColor.Blue },
                new Data { Name = "Ken", EyeColor = EyeColor.Brown },
                new Data { Name = "Sam", EyeColor = EyeColor.Blue },
                new Data { Name = "Harry", EyeColor = EyeColor.Green },
                new Data { Name = "Tom", EyeColor = EyeColor.Green },
                new Data { Name = "John", EyeColor = EyeColor.Black },
                new Data { Name = "Mark", EyeColor = EyeColor.Brown },
            };
        }

        public ObservableCollection<Data> Data { get; set; }
    }
}