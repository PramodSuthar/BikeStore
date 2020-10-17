using System;
using System.Collections.Generic;
using System.Text;

namespace MyBikesStore
{
    [Serializable]
    public class MountainBike : Bike
    {
        private EnumSuspension suspension;
        public MountainBike(long sr, string make, double speed, EnumColor color,
            MyBikesStore.Date date, EnumSuspension suspension) : base(sr, make, speed, color, date)
        {
            this.suspension = suspension;
        }

        public override void SpeedUp(double newSpeed)
        {
            if ((speed + newSpeed) < GetMaxSpeed())
                speed += newSpeed;
        }

        public EnumSuspension Suspension { get => suspension; set => suspension = value; }
        public override string ToString()
        {
            return base.ToString() + "\t\t-\t\t" + suspension;
        }
    }
}
