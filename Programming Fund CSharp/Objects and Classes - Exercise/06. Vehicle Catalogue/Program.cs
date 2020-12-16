using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Car> car = new List<Car>();
            List<Truck> truck = new List<Truck>();
            while (input != "End")
            {
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (info[0] == "car")
                {
                    Car carInfo = new Car(info[0], info[1], info[2], int.Parse(info[3]));
                    car.Add(carInfo);
                }
                else if (info[0] == "truck")
                {
                    Truck truckInfo = new Truck(info[0], info[1], info[2], int.Parse(info[3]));
                    truck.Add(truckInfo);
                }
                input = Console.ReadLine();
            }


            string secondInput = Console.ReadLine();

            while (secondInput != "Close the Catalogue")
            {
                
                if (car.FirstOrDefault(x => x.Model == secondInput) != null)
                {


                    Console.WriteLine(car.FirstOrDefault(x => x.Model == secondInput).ToString()); 

                }
                if (truck.FirstOrDefault(x => x.Model == secondInput) != null)
                {
                    Console.WriteLine(truck.FirstOrDefault(x => x.Model == secondInput).ToString());

                }
                secondInput = Console.ReadLine();
            }
            double avarageCar = car.Sum(x => x.HorsePower*1.0 / car.Count);
            double avarageTruck = truck.Sum(x => x.HorsePower*1.0 / truck.Count);
            Console.WriteLine($"Cars have average horsepower of: {avarageCar:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avarageTruck:f2}.");
        }

        class Car
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

            public Car(string type, string model, string color, int horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
                
            }
            public override string ToString()
            {
                StringBuilder toPrint = new StringBuilder();

                toPrint.AppendLine($"Type: Car");
                toPrint.AppendLine($"Model: {this.Model}");
                toPrint.AppendLine($"Color: {this.Color}");
                toPrint.AppendLine($"Horsepower: {this.HorsePower}");

                return toPrint.ToString().TrimEnd();
            }

        }
        class Truck
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

            public Truck(string type, string model, string color, int horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }
            public override string ToString()
            {
                StringBuilder toPrint = new StringBuilder();

                toPrint.AppendLine($"Type: Truck");
                toPrint.AppendLine($"Model: {this.Model}");
                toPrint.AppendLine($"Color: {this.Color}");
                toPrint.AppendLine($"Horsepower: {this.HorsePower}");

                return toPrint.ToString().TrimEnd();
            }
        }
    }
}
