using System;
using System.Collections.Generic;
using System.Text;

namespace MyBikesStore
{
    [Serializable]
    public abstract class Bike : IMovable
    {
        private long serialNumber;
        protected string make;
        protected double speed;
        protected EnumColor color;
        protected MyBikesStore.Date date;

        public long SerialNumber { get => serialNumber; }

        public Bike() { }

        public Bike(long sr, string make, double speed, EnumColor color, MyBikesStore.Date date)
        {
            this.serialNumber = sr;
            this.color = color;
            this.date = date;
            this.make = make;
            this.speed = speed;

        }

        public virtual double GetMaxSpeed()
        {
            return 20;
        }

        public abstract void SpeedUp(double newSpeed);

        public override string ToString()
        {
            return SerialNumber +
                "\t" + make +
                "\t\t" + speed +
                "\t\t" + color +
                "\t\t" + date.ToString();
        }

    }
}
