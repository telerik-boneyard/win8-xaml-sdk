using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_EditCommands
{
    public class ViewModel
    {
        public ViewModel()
        {
            GridSource = new ObservableCollection<Data>()
            {
                new Data { Team = "Lazio", Country = "Italy" },
                new Data { Team = "Chelsea", Country = "England" },
                new Data { Team = "Barcelona", Country = "Germany" },
                new Data { Team = "Lens", Country = "France" },
            };
        }

        public ObservableCollection<Data> GridSource { get; set; }
    }
}