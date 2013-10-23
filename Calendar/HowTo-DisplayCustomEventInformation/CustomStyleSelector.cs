using Telerik.UI.Xaml.Controls.Input.Calendar;
using Windows.UI.Xaml;
using System.Linq;

namespace HowTo_DisplayCustomEventInformation
{
    public class CustomStyleSelector : CalendarCellStyleSelector
    {
        public DataTemplate EventTemplate { get; set; }

        protected override void SelectStyleCore(CalendarCellStyleContext context, Telerik.UI.Xaml.Controls.Input.RadCalendar container)
        {
            var events = (container.DataContext as ViewModel).Events;

            if (events.Where(e => e.Date == context.Date).Count() > 0)
            {
                context.CellTemplate = this.EventTemplate;
            }
        }
    }
}