using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styling_ImplicitStyles
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.GridSource = new List<Data>()
                                  {
                                      new Data{ Team = "Manchester United", Country =  "England"},
                                      new Data{ Team = "Monaco", Country =  "France"},
                                      new Data{ Team = "West Ham", Country =  "England"},
                                      new Data{ Team = "Napoli", Country =  "Italy"},
                                      new Data{ Team = "Juventus", Country =  "Italy"},

                                  };
        }
        public List<Data> GridSource { get; set; }
    }
}
