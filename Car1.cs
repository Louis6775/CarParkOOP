using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkExersice
{
    class Car1 : Vehicle
    {
        public Car1(int time, string number, string colour): base(time, number)
        {
            carcolour = colour;
        }
        public string carcolour { get; set; }
    }
}
