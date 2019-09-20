using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle
    {
        public Car(string licensePlate, bool broBizzCard = false) : base(licensePlate, broBizzCard)
        {
            LicensePlate = licensePlate;
            Price = 240;
            VehicleType = "Car";
            BroBizz = broBizzCard;
        }
    }
}
