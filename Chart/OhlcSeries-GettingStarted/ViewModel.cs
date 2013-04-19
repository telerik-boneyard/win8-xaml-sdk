using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhlcSeries_GettingStarted
{
    public class ViewModel
    {
        public ObservableCollection<FinancialData> GetData
        {
            get
            {
                ObservableCollection<FinancialData> collection = new ObservableCollection<FinancialData>();
                collection.Add(new FinancialData() { High = 10, Open = 5, Low = 2, Close = 8 });
                collection.Add(new FinancialData() { High = 15, Open = 7, Low = 3, Close = 5 });
                collection.Add(new FinancialData() { High = 20, Open = 15, Low = 10, Close = 19 });
                collection.Add(new FinancialData() { High = 7, Open = 2, Low = 1, Close = 5 });
                collection.Add(new FinancialData() { High = 25, Open = 15, Low = 10, Close = 12 });
                return collection;
            }
        }
    }
}
