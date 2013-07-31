using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_CellDoubleTappedCommand
{
    public class Details
    {
        public string Season { get; set; }

        public string Place { get; set; }

        public List<WDL> WDL { get; set; }

        public int Points { get; set; }
    }
}