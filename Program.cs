using System;
using System.Collections.Generic;


//Program to add a given number of vehicles to a List

namespace Program
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            NewVehicle entry = new NewVehicle();

            Console.Write("How many vehicles do you want to add:");
            string amount = Console.ReadLine(); ;
            int intAmount = Convert.ToInt32(amount);

            var duplicateCheck = new List<string>();

            for (int i = 1; i <= intAmount; i++)
            {
                Console.WriteLine("Add model, brand and year:");
                string model = Console.ReadLine();

                if (!duplicateCheck.Contains(model))
                { duplicateCheck.Add(model); }
                else
                { Console.WriteLine("This vehicle model already exists! Please add another vehicle model.");
                    string temporary = Console.ReadLine();
                    model = temporary;
                }
                string brand = Console.ReadLine();
                string year = Console.ReadLine();

                entry.newVehicle(model, brand, year);
            }
        }
    }


    public class NewVehicle
    {
        List<Vehicles> library = new List<Vehicles>();

        public void newVehicle(string Model, string Brand, string Year)
        {
            Vehicles vehicle = new Vehicles
            {
                model = Model,
                brand = Brand,
                year = Year
            };
            library.Add(vehicle);
        }
    }


    class Vehicles
    {
        public string model;
        public string brand;
        public string year;
    }
}