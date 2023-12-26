using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class MyDate
    {
        public int Year {  get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public MyDate()
        {
            Year = 2020;
            Month = 00;
            Day = 10;
            Hours =  12;
            Minutes = 30;
        }

        public MyDate(int year, int  month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public MyDate(int month, int day, int hours, int minutes)
        {
            Year = 2024;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public MyDate(MyDate obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }
    }
}
