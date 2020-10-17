using System;
using System.Collections.Generic;
using System.Text;

namespace MyBikesStore
{
    [Serializable]
    public class Roadbike : Bike
    {
        private double seatHeight;
        public Roadbike(long sr, string make, double speed, EnumColor color,
            MyBikesStore.Date date, double seatHeight) : base(sr, make, speed, color, date)
        {
            this.SeatHeight = seatHeight;
        }

        public override void SpeedUp(double newSpeed)
        {
            if ((speed + newSpeed) < GetMaxSpeed())
                speed += newSpeed;
        }

        public override double GetMaxSpeed()
        {
            return 40;
        }

        public double SeatHeight { get => seatHeight; set => seatHeight = value; }

        public override string ToString()
        {
            return base.ToString() + "\t\t" + SeatHeight + "\t\t-";
        }
    }
}
