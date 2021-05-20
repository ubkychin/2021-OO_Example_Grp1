using System;
using System.Collections.Generic;

namespace OO_Example_Grp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Car c1 = new Car("ABC123", 0);
            Car c2 = new Car("CBA321", 10);
            Car c3 = new Car("ZXC980", 30);

            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);


            RaceTrack track = new RaceTrack("Flemington", 12, "Victoria", cars);
            track.AddCar(new Car("POT876", 50));
            track.AddCar(new Car("TOP676", 5));
            

            track.PrintCars();
            System.Console.WriteLine("===============================");
            Console.WriteLine(track.GetFastestCar().Rego);


        }
    }
}
