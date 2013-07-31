using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_HowTo_CreateCustomFilteringControl
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Data = new ObservableCollection<Data>(){ new Data{ Country = "Spain", Continent = "Europe", IsFromEurope =  true},
                                                      new Data{ Country = "Argentina", Continent = "South America", IsFromEurope = false},
                                                      new Data{ Country = "England", Continent = "Europe", IsFromEurope = true},
                                                      new Data{ Country = "South Africa", Continent = "Africa", IsFromEurope = false},
        };
        }
        public ObservableCollection<Data> Data { get; set; }
    }
}
