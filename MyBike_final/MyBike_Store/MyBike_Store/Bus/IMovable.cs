using System;
using System.Collections.Generic;
using System.Text;

namespace MyBikesStore
{
    interface IMovable
    {
        double GetMaxSpeed();
        void SpeedUp(double newSpeed);
    }
}
