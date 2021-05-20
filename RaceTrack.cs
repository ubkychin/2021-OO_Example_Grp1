
using System.Collections.Generic;

namespace OO_Example_Grp1
{
    public class RaceTrack
    {
        // attributes
        public string Name;
        public int Length;
        public string Location;
        public List<Car> Cars;

        // constructor
        public RaceTrack(string name, int length, string location, List<Car> cars)
        {
            this.Name = name;
            this.Length = length;
            this.Location = location;
            this.Cars = cars;
        }

        public void AddCar(Car newCar) {
            this.Cars.Add(newCar);
        }

        public void PrintCars() {
            foreach(Car c in this.Cars) {
                System.Console.WriteLine($"{c.Rego} is going {c.Speed}km/h");
            }
        }

        public Car GetFastestCar() {
            // Look through the list of cars and their speeds
            // compare each stick/car speed to the current max
            // if it's less or the same move on
            // if it's larger it becomes the new max
            
            // int fastestSpeed = this.Cars[0].Speed;
            Car fastestCar = this.Cars[0];

            // foreach(Car c in this.Cars) {                
            //     if (c.Speed > fastestSpeed) {
            //         fastestSpeed = c.Speed;
            //         fastestCar = c;
            //     }
            // }

            foreach(Car c in this.Cars) {                
                if (c.Speed > fastestCar.Speed) {
                    fastestCar = c;
                }
            }

            return fastestCar;
        }



    }
}