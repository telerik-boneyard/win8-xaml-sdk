using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_ColumnHeaderTapCommand
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.GridSource = new List<CustomData>
            {
                new CustomData { Team = "Manchester United", GroundCapacity = 75765 },
                new CustomData { Team = "Arsenal", GroundCapacity = 60361 },
                new CustomData { Team = "Real Madrid", GroundCapacity = 85454 },
                new CustomData { Team = "Internazionale", GroundCapacity = 80018 },
                new CustomData { Team = "Chelsea", GroundCapacity = 41837 },
                new CustomData { Team = "Borussia Dortmund", GroundCapacity = 80720, },
                new CustomData { Team = "Bayern Munich", GroundCapacity = 71137 },
                new CustomData { Team = "Boca Juniors", GroundCapacity = 49000 },
            };
        }

        public List<CustomData> GridSource { get; set; }
    }
}