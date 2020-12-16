using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    
    class Box
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForOneBox { get; set; }
        public decimal TotalPrice { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> result = new List<Box>();

           

            while (input != "end")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = command[0];
                string itemName = command[1];
                int itemQuantity = int.Parse(command[2]);
                decimal priceForOneBox = decimal.Parse(command[3]);

                Box orderBox = new Box();

                orderBox.SerialNumber = serialNumber;
                orderBox.ItemName = itemName;
                orderBox.ItemQuantity = itemQuantity;
                orderBox.PriceForOneBox = priceForOneBox;
                orderBox.TotalPrice = priceForOneBox*itemQuantity;

                result.Add(orderBox);


                input = Console.ReadLine();


            }

           List<Box> sorted= result.OrderBy(big => big.TotalPrice).ToList();
            sorted.Reverse();
            foreach (Box item in sorted)
            {
               
                    Console.WriteLine($"{item.SerialNumber}");
                    Console.WriteLine($"-- {item.ItemName} - ${item.PriceForOneBox:f2}: {item.ItemQuantity}");
                    Console.WriteLine($"-- ${item.PriceForOneBox * item.ItemQuantity:f2}");
                
            }

        }


    }
}
