using System.Collections.ObjectModel;

namespace Columns_TemplateColumnGroupDescriptor
{
    public class ViewModel
    {
        public ViewModel()
        {
            FillData();
        }

        public ObservableCollection<Data> Collection { get; set; }

        private void FillData()
        {
            this.Collection = new ObservableCollection<Data>()
            {
                new Data() { FirstName = "Peter", LastName = "Hillam", Age = 22 },
                new Data() { FirstName = "Erik", LastName = "Smith", Age = 23 },
                new Data() { FirstName = "Rayan", LastName = "Simpson", Age = 21 },
                new Data() { FirstName = "Stephen", LastName = "Bramson", Age = 22 },
                new Data() { FirstName = "Samuel", LastName = "Perry", Age = 25 }
            };
        }
    }
}