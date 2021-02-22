using System;

namespace CarParkExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car1 redcar = new Car1(8, "EF87Y6", "red");
            Motorbike blackmotorbike = new Motorbike(19, "HF78K1", "black", "motorbike");
            Console.WriteLine("The " + redcar.carcolour + " car owes " + calculateCharges(redcar.timeparked));
            Console.WriteLine("The " + blackmotorbike.vehiclecolour + " " + blackmotorbike.twowheelvehicle + " owes " + calculateCharges(blackmotorbike.timeparked));
        }

        public static double calculateCharges(double timespent)
        {
            if (timespent <= 3)
            {
                return 2;
            }
            if (timespent <= 17)
            {
                return (2 + (timespent - 3) * 0.5);
            }
            return 10;
        }
    }
}
