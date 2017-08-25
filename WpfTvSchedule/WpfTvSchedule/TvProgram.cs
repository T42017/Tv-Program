using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTvSchedule
{
    public class TvProgram
    {

        public DateTime StartDateTime { get; set; }
        public DateTime StopDateTime { get; set; }
        public string Title { get; set; }

        public string StartTime
        {
            get { return StartDateTime.ToShortTimeString(); }
        }

        public TvProgram(DateTime startDateTime, DateTime stopDateTime, string title)
        {
            this.StartDateTime = startDateTime;
            this.StopDateTime = stopDateTime;
            this.Title = title;
        }
    }
}
