using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Vehicle
    {
        public MC(string licensePlate, bool broBizzCard = false) : base(licensePlate, broBizzCard)
        {
            LicensePlate = licensePlate;
            Price = 125;
            VehicleType = "Motorcycle";
            BroBizz = broBizzCard;
        }
    }
}
