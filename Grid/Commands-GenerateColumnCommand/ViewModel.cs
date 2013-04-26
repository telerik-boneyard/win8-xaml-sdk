using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_GenerateColumnCommand
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.GridSource = new ObservableCollection<Person>()
                                                               {
                                                                   new Person{ FirstName = "Ivaylo", LastName = "Gergov", ID = 9005194361},
                                                                   new Person{ FirstName = "Aleksandar", LastName = "Petrov", ID = 8511120513},
                                                                   new Person{ FirstName = "Tsvyatko", LastName = "Andonov", ID = 8608221001},
                                                                   new Person{ FirstName = "Manol", LastName = "Zaimov", ID = 8210022011},

                                                               };
        }
        public ObservableCollection<Person> GridSource { get; set; }

    }
}
