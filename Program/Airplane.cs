using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class Airplane
    {
        public string StartCity { get; set; }
        public string FinishCity { get; set; }
        public MyDate StartDate { get; set; }
        public MyDate FinishDate { get; set; }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(MyDate startDate, MyDate finishDate)
        {
            StartCity = "Toronto";
            FinishCity = "Glazgow";
            StartDate = startDate;
            FinishDate = finishDate;

        }
        public Airplane()
        {
            StartCity = "Paris";
            FinishCity = "Madrid";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }

        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = new MyDate(airplane.StartDate);
            FinishDate = new MyDate(airplane.FinishDate);
        }
        public int GetTotalTime()
        {
            DateTime startDateTime = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartDate.Hours, StartDate.Minutes, 0);
            DateTime finishDateTime = new DateTime(FinishDate.Year, FinishDate.Month, FinishDate.Day, FinishDate.Hours, FinishDate.Minutes, 0);

            TimeSpan totalTime = finishDateTime - startDateTime;
            return (int)totalTime.TotalMinutes;
        }
            public bool IsArrivingToday()
        {
            if (StartDate.Day == FinishDate.Day)
                return true;
            return false;
        }
    }
}
