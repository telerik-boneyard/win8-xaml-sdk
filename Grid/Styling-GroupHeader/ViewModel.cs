using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styling_GroupHeader
{
    public class ViewModel
    {
        public List<CustomData> GridSource { get; set; }
        public ViewModel()
        {
          this.GridSource   = new List<CustomData>
                                     {

                                         new CustomData { Country = "Brazil", City = "Caxias do Sul"},
                                         new CustomData { Country = "Ghana", City = "Wa"},
                                         new CustomData { Country = "Brazil", City = "Fortaleza"},
                                         new CustomData { Country = "Italy", City = "Florence" },
                                         new CustomData { Country = "France", City = "Bordeaux" }, 
                                         new CustomData { Country = "Bulgaria", City = "Vratsa"},
                                         new CustomData { Country = "Spain", City = "Las Palmas"},
                                         new CustomData { Country = "France", City = "Le Mans" },
                                         new CustomData { Country = "Brazil", City = "Santos"},
                                         new CustomData { Country = "Ghana", City = "Ho"},
                                         new CustomData { Country = "Spain", City = "Malaga"},
                                         new CustomData { Country = "France", City = "Marseille" },
                                         new CustomData { Country = "Bulgaria", City = "Koynare" },  
                                         new CustomData { Country = "Spain", City = "Valencia"},
                                         new CustomData { Country = "Ghana", City = "Kade" },
                                         new CustomData { Country = "Brazil", City = "Porto Alegre" }, 
                                         new CustomData { Country = "Bulgaria", City = "Byala Slatina"},
                                         new CustomData { Country = "Italy", City = "Naples" },
                                         new CustomData { Country = "Brazil", City = "Joinville" }, 
                                     };
        }
       
    }
}
