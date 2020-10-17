using System;
using System.Collections.Generic;
using System.Text;

namespace MyBikesStore
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    [Serializable]
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date() { }

        public Date(int dd, int mm, int yyyy)
        {
            this.Day = dd;
            this.Month = mm;
            this.Year = yyyy;

        }

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public override string ToString()
        {
            return day +
                "/" + month +
                "/" + year;
        }
    }
}
