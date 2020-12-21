﻿using System;
using static Lesson_7.Enums;

namespace Lesson_7
{
    internal class Program
    {
        private static Catalogue<Car> cars = new Catalogue<Car>();

        private static void Main(string[] args)
        {
            cars.Add(new Car { Make = Make.Ford, Model = Model.Escape, Color = Color.Blue, Year = 2020 });
            cars.Add(new Car { Make = Make.Ford, Model = Model.Focus, Color = Color.Blue, Year = 2020 });
            cars.Add(new Car { Make = Make.Renault, Model = Model.Megane, Color = Color.Blue, Year = 2020 });
            cars.Add(new Car { Make = Make.Toyota, Model = Model.Corolla, Color = Color.Blue, Year = 2020 });
            cars.Add(new Car { Make = Make.Toyota, Model = Model.Camry, Color = Color.Blue, Year = 2020 });

            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    break;
                }
                else
                {
                    switch (choice)
                    {
                        case "1":
                            AddNewCar();
                            break;

                        case "2":
                            RemoveCar();
                            break;

                        case "3":
                            ListAllCars();
                            break;
                    }
                }
            }
        }

        private static void ListAllCars()
        {
            Console.Clear();

            cars.List();

            EnterToContinue();
        }

        private static void EnterToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }

        private static void RemoveCar()
        {
            Console.Clear();
            Console.Write("Please enter an index of car to remove: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int i))
            {
                if (cars.Remove(i))
                {
                    Console.WriteLine("Car was removed from the list");
                }
                else
                {
                    Console.WriteLine("Car was NOT removed from the list");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number for the index.");
            }

            EnterToContinue();
        }

        private static void AddNewCar()
        {
            throw new NotImplementedException();
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("1. Add new car");
            Console.WriteLine("2. Remove car");
            Console.WriteLine("3. List all cars");
            Console.WriteLine("4. Search for car");
            Console.WriteLine("5. Exit");
            Console.WriteLine("=========================");
            Console.Write("Please enter your choice (1-5) ");
        }
    }
}