using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Columns_AddTextColumns
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.GridSource = new ObservableCollection<Data>()
                                                             {
                                                              new Data{ Team = "Manchester United", Country = "England"},
                                                              new Data{ Team = "Real Madrid", Country = "Spain"},
                                                              new Data{ Team = "Bayern Munich", Country = "Germany"},
                                                              new Data{ Team = "Lazio", Country = "Italy"},
                                                             };
        }
        public ObservableCollection<Data> GridSource { get; set; }

    }
}
