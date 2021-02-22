using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkExersice
{
    class Vehicle
    {
        public Vehicle(int time, string number)
        {
            timeparked = time;
            numberplate = number;
        }
        public int timeparked { get; set; }
        public string numberplate { get; set; }
    }
}
