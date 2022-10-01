using System;

namespace DateModifier
{
    public class DateModifier
    {
        public DateModifier(DateTime start, DateTime end)
        {
            StartDateTime = start;
            EndDateTime = end;
            time = (int)(EndDateTime - StartDateTime).TotalDays;
        }
        private int time;
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public int Time
        {
            get
            {
                return time;
            }
        }

    }
}
