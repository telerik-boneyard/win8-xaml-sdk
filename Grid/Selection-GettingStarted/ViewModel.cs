using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_GettingStarted
{
    public class ViewModel
    {
        public ViewModel()
        {
           this.GridSource = new List<Data>
                                     {
                                         new Data { Country = "India", Capital = "New Delhi"},
                                         new Data { Country = "South Africa", Capital = "Cape Town"},
                                         new Data { Country = "Nigeria", Capital = "Abuja" },
                                         new Data { Country = "Singapor", Capital = "Singapor" }                             
                                     };
        }
        public List<Data> GridSource { get; set; }
    }
}
