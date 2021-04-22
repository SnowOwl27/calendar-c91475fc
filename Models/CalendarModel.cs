using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CalendarEventWebApp.Models
{
    public class CalendarModel
    {
        public int DayOfMonth { get; set; }
        public string DayOfWeek { get; set; }
        public int Month { get; set; }
        public string MonthName
        {
            get
            {
                switch (Month)
                {
                    case 1:
                        return "January";
                    case 2:
                        return "February";
                    case 3:
                        return "March";
                    case 4:
                        return "April";
                    case 5:
                        return "May";
                    case 6:
                        return "June";
                    case 7:
                        return "July";
                    case 8:
                        return "August";
                    case 9:
                        return "September";
                    case 10:
                        return "October";
                    case 11:
                        return "November";
                    case 12:
                        return "December";
                    default:
                        return "Unknown Month";
                }
            }
        }
    }
}
