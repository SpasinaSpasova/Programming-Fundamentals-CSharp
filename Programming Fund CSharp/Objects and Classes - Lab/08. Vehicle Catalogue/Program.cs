using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (input != "end")
            {
                string[] commnad = input.Split("/", StringSplitOptions.RemoveEmptyEntries);

                string type = commnad[0];

                if (type == "Car")
                {
                    Car car = new Car(commnad[1], commnad[2], int.Parse(commnad[3]));

                    cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(commnad[1], commnad[2], int.Parse(commnad[3]));

                    trucks.Add(truck);
                }
                input = Console.ReadLine();
            }
            if (cars.Count > 0)
            {


                Console.WriteLine("Cars:");
                List<Car> sortedCar = cars.OrderBy(x => x.Brand).ToList();
                foreach (var item in sortedCar)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {


                Console.WriteLine("Trucks:");
                List<Truck> sortedTruck = trucks.OrderBy(n => n.Brand).ToList();
                foreach (var item in sortedTruck)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }

            public Truck(string brand,string model, int weight )
            {
                this.Brand = brand;
                this.Model = model;
                this.Weight = weight;
            }
        }
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }

            public Car(string brand, string model, int horsePower)
            {
                this.Brand = brand;
                this.Model = model;
                this.HorsePower = horsePower;
            }
        }

        
    }
}
