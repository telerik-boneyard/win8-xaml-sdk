using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.UI.Xaml.Controls.Chart;
using Telerik.UI.Xaml.Controls.Grid;
using Windows.UI.Xaml.Controls;

namespace Commands_CellPointerOverCommand
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ObservableCollection<LastResults> seriesSource;
         
        public ViewModel()
        {
            var manchesterUHistory = new ObservableCollection<LastResults>() { new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 0 }, new LastResults { Result = 2 }, new LastResults { Result = 1 } };
            var manchesterCHistory = new ObservableCollection<LastResults>() { new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 0 }, new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 2 } };
            var chelseaHistory = new ObservableCollection<LastResults>() { new LastResults { Result = 0 }, new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 0 }, new LastResults { Result = 2 }, new LastResults { Result = 2 } };
            var arsenalHistory = new ObservableCollection<LastResults>() { new LastResults { Result = 0 }, new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 1 } };
            var tottenhamHistory = new ObservableCollection<LastResults>() { new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 0 }, new LastResults { Result = 0 }, new LastResults { Result = 2 }, new LastResults { Result = 1 } };
            var evertonHistory = new ObservableCollection<LastResults>() { new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 2 }, new LastResults { Result = 1 }, new LastResults { Result = 2 }, new LastResults { Result = 1 } };
            this.GridSource = new ObservableCollection<Data>()
            {
                new Data{ Team = "Manchester United", Points = 81, LastMatches = manchesterUHistory},
                new Data{ Team = "Manchester City", Points = 68,LastMatches = manchesterCHistory },
                new Data{ Team = "Chelsea", Points = 61,LastMatches = chelseaHistory },
                new Data{ Team = "Arsenal", Points = 60,LastMatches = arsenalHistory },
                new Data{ Team = "Tottenham", Points = 58,LastMatches = tottenhamHistory },
                new Data{ Team = "Everton", Points = 56,LastMatches = evertonHistory },

            };
             
        }
        string chartHeader;
        public string ChartHeader
        {
            get
            {
                return chartHeader;
            }
            set
            {
                chartHeader = value;
                OnPropertyChanged("ChartHeader");
            }
        }
        public ObservableCollection<Data> GridSource { get; set; }
        public ObservableCollection<LastResults> SeriesSource
        {
            get
            {
                return seriesSource;
            }
            set
            {
                seriesSource = value;
                OnPropertyChanged("SeriesSource");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        

        
    }
}
