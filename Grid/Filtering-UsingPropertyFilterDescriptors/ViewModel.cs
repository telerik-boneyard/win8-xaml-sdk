using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_UsingPropertyFilterDescriptors
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.GridSource = new List<CustomData>
                           {
                             new CustomData { Team = "Manchester United", Founded = new DateTime(1878,1,1), GroundCapacity = 75765, IsFromPremierLeague = true}, 
                             new CustomData { Team = "Arsenal", Founded = new DateTime(1886,1,1), GroundCapacity = 60361, IsFromPremierLeague = true},
                             new CustomData { Team = "Real Madrid", Founded = new DateTime(1902,3,6),GroundCapacity = 85454}, 
                             new CustomData { Team = "Internazionale", Founded = new DateTime(1908,3,9), GroundCapacity = 80018}, 
                             new CustomData { Team = "Chelsea", Founded = new DateTime(1906,4,10),GroundCapacity = 41837, IsFromPremierLeague = true},
                             new CustomData { Team = "Borussia Dortmund", Founded = new DateTime(1909,12,19), GroundCapacity = 80720,},
                             new CustomData { Team = "Bayern Munich", Founded = new DateTime(1900,2,27),GroundCapacity = 71137}, 
                             new CustomData { Team = "Boca Juniors",Founded = new DateTime(1905,4,3),GroundCapacity = 49000},                       
                         };
        }
        public List<CustomData> GridSource { get; set; }
    }
}
