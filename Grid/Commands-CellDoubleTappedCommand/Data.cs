using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_CellDoubleTappedCommand
{
    public class Data
    {
        public string Team { get; set; }
        public string Country { get; set; }
        public ObservableCollection<Details> DetailsSource { get; set; }
 
    }
}
