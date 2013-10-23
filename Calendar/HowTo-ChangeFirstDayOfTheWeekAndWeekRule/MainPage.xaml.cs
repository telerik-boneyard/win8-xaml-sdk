using System;
using System.Globalization;
using Telerik.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace HowTo_ChangeFirstDayOfTheWeekAndWeekRule
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.calendar.DisplayDate = new DateTime(2002,9,1);
            CultureInfo culture = new CultureInfo("en-US");
            culture.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Wednesday;
            culture.DateTimeFormat.CalendarWeekRule = CalendarWeekRule.FirstFullWeek;
            CultureService.SetCulture(this.calendar, culture);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}