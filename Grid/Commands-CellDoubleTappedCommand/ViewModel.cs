using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Commands_CellDoubleTappedCommand
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.GridSource = new ObservableCollection<Data>()
            {
                new Data { Team = "Manchester United", Country = "England", DetailsSource = manDetails },
                new Data { Team = "Real Madrid", Country = "Spain", DetailsSource = realDetails },
                new Data { Team = "Bayern Munich", Country = "Germany", DetailsSource = bayernDetails },
                new Data { Team = "Lazio", Country = "Italy", DetailsSource = lazioDetails },
            };
        }

        public ObservableCollection<Data> GridSource { get; set; }

        ObservableCollection<Details> manDetails = new ObservableCollection<Details>()
        {
            new Details { Season = "2011/2012", Place = "2nd", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 28 }, new WDL { Category = "Draws", Value = 5 }, new WDL { Category = "Losses", Value = 5 } }, Points = 89 },
            new Details { Season = "2010/2011", Place = "1st", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 23 }, new WDL { Category = "Draws", Value = 11 }, new WDL { Category = "Losses", Value = 4 } }, Points = 80 },
            new Details { Season = "2009/2010", Place = "2nd", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 27 }, new WDL { Category = "Draws", Value = 4 }, new WDL { Category = "Losses", Value = 7 } }, Points = 85 },
            new Details { Season = "2008/2009", Place = "1st", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 28 }, new WDL { Category = "Draws", Value = 6 }, new WDL { Category = "Losses", Value = 4 } }, Points = 90 },
        };

        ObservableCollection<Details> realDetails = new ObservableCollection<Details>()
        {
            new Details { Season = "2011/2012", Place = "1st", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 32 }, new WDL { Category = "Draws", Value = 4 }, new WDL { Category = "Losses", Value = 2 } }, Points = 100 },
            new Details { Season = "2010/2011", Place = "2nd", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 29 }, new WDL { Category = "Draws", Value = 5 }, new WDL { Category = "Losses", Value = 4 } }, Points = 92 },
            new Details { Season = "2009/2010", Place = "2nd", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 31 }, new WDL { Category = "Draws", Value = 3 }, new WDL { Category = "Losses", Value = 4 } }, Points = 96 },
            new Details { Season = "2008/2009", Place = "2nd", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 25 }, new WDL { Category = "Draws", Value = 3 }, new WDL { Category = "Losses", Value = 10 } }, Points = 78 },
        };

        ObservableCollection<Details> bayernDetails = new ObservableCollection<Details>()
        {
            new Details { Season = "2011/2012", Place = "2nd", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 23 }, new WDL { Category = "Draws", Value = 4 }, new WDL { Category = "Losses", Value = 7 } }, Points = 73 },
            new Details { Season = "2010/2011", Place = "3rd", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 19 }, new WDL { Category = "Draws", Value = 8 }, new WDL { Category = "Losses", Value = 7 } }, Points = 65 },
            new Details { Season = "2009/2010", Place = "1st", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 20 }, new WDL { Category = "Draws", Value = 10 }, new WDL { Category = "Losses", Value = 4 } }, Points = 70 },
            new Details { Season = "2008/2009", Place = "2nd", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 20 }, new WDL { Category = "Draws", Value = 7 }, new WDL { Category = "Losses", Value = 7 } }, Points = 67 },
        };

        ObservableCollection<Details> lazioDetails = new ObservableCollection<Details>()
        {
            new Details { Season = "2011/2012", Place = "4th", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 18 }, new WDL { Category = "Draws", Value = 8 }, new WDL { Category = "Losses", Value = 12 } }, Points = 62 },
            new Details { Season = "2010/2011", Place = "5th", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 20 }, new WDL { Category = "Draws", Value = 6 }, new WDL { Category = "Losses", Value = 12 } }, Points = 66 },
            new Details { Season = "2009/2010", Place = "12th", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 11 }, new WDL { Category = "Draws", Value = 13 }, new WDL { Category = "Losses", Value = 14 } }, Points = 46 },
            new Details { Season = "2008/2009", Place = "10th", WDL = new List<WDL>() { new WDL { Category = "Wins", Value = 15 }, new WDL { Category = "Draws", Value = 5 }, new WDL { Category = "Losses", Value = 18 } }, Points = 50 },
        };
    }
}