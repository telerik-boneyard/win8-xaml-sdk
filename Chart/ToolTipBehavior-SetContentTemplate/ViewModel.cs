using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolTipBehavior_SetContentTemplate
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.Data = this.GetData();
        }
        public List<CustomPoint> Data
        {
            get;
            set;
        }

        private List<CustomPoint> GetData()
        {
            List<CustomPoint> data = new List<CustomPoint>();
            data.Add(new CustomPoint() { Category = "Apples", Value = 10, SecondValue = 5, Country = "Bulgaria", SecondCountry = "Italy" });
            data.Add(new CustomPoint() { Category = "Oranges", Value = 12, SecondValue = 9, Country = "Brazil", SecondCountry = "USA" });
            data.Add(new CustomPoint() { Category = "Pineaples", Value = 8, SecondValue = 13, Country = "Philippines", SecondCountry = "Brazil" });
            return data;
        }
    }
}
