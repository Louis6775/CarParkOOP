using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkExersice
{
    class Motorbike : Vehicle
    {
        public Motorbike(int time, string number, string colour, string twowheel) : base (time, number)
        {
            vehiclecolour = colour;
            twowheelvehicle = twowheel;
        }
        public string twowheelvehicle {get; set;}
        public string vehiclecolour;
    }
}
