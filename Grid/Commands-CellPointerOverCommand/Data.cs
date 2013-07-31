using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_CellPointerOverCommand
{
    public class Data
    {
        public string Team { get; set; }

        public int Points { get; set; }

        public ObservableCollection<LastResults> LastMatches { get; set; }
    }
}