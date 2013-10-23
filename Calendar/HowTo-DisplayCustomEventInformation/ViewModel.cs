using System;
using System.Collections.Generic;

namespace HowTo_DisplayCustomEventInformation
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.CreateEvents();
        }

        private void CreateEvents()
        {
            DateTime date = new DateTime(2002, 9, 1);
            List<EventInfo> data = new List<EventInfo>();
             
             data.Add(new EventInfo() { Date = date.AddDays(2), Title = "First Event", Details = "First Event Details... ", Symbol = '\uE082' });
             data.Add(new EventInfo() { Date = date.AddDays(3), Title = "Second Event", Details = "Second Event Details...", Symbol = '\uE0A5' });
             data.Add(new EventInfo() { Date = date.AddDays(5), Title = "Third Event", Details = "Third Event Details...", Symbol = '\u23F0' });

            this.Events = data;
        }

        public List<EventInfo> Events { get; set; }
    }
}