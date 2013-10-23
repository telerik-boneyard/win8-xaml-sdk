using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarSeries_GettingStarted
{
    public class ViewModel
    {
        public ObservableCollection<FinancialData> GetData
        {
            get
            {
                double a = 0.5;
                var b = (Math.PI / 180);
                ObservableCollection<FinancialData> collection = new ObservableCollection<FinancialData>();
                for (int i = 1; i < 5 * 360; i += 10)
                {
                    collection.Add(new FinancialData() { Angle = i, Value = (a * Math.Cos(20 * i * b)) });
                }
                return collection;
            }
        }
    }
}
