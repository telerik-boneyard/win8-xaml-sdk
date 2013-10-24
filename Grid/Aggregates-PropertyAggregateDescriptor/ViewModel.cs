using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates_PropertyAggregateDescriptor
{
    public class ViewModel
    {
        public ViewModel()
        {
            GridSource = new ObservableCollection<Data>()
            {
                new Data{ Team = "Lazio", Points = 80},
                new Data{ Team = "Lazio", Points = 60},
                new Data{ Team = "Bayern", Points = 100},
                new Data{ Team = "Bayern", Points = 120},
                new Data{ Team = "Bayern", Points = 50},

            };

        }
        public ObservableCollection<Data> GridSource { get; set; }
    }
}
