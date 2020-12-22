using System;
using POP_Assignment;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter First Name: ");
            string First_name = Console.ReadLine();
            Console.WriteLine("Please enter Last_name: ");
            string Last_name = Console.ReadLine();


            Console.WriteLine("Please input Student_number: ");
            string Student_number = Console.ReadLine();
            Console.WriteLine("Please input Age: ");
            int Age = int.Parse(Console.ReadLine());


            Console.WriteLine("Please input total amount of scores you wish to enter ");
            int Scores_Length = int.Parse(Console.ReadLine());
            int[] Scores = new int[Scores_Length];
            int count = 0;
            while (count < Scores_Length)
            {
                Console.WriteLine((count + 1) + ". Please enter score: ");
                Scores[count] = int.Parse(Console.ReadLine());
                count++;

            }

            Console.WriteLine("Please input your address information. ");
            Console.WriteLine("Please input address: ");
            string Address = Console.ReadLine();
            Console.WriteLine("Please input Street: ");
            string Street = Console.ReadLine();
            Console.WriteLine("Please input City: ");
            string City = Console.ReadLine();
            Console.WriteLine("Please input Country: ");
            string Country = Console.ReadLine();


            Address address = new Address(Address, Street, City, Country);
            Student student = new Student(First_name, Last_name, Student_number, Age, Scores);


            Console.WriteLine(student.Full_name + " your score is " + student.average_score);
            Console.WriteLine(student.Full_name + " is living in " + address.City);
            Console.WriteLine(student.Full_name + " is living in " + address.Full_Address);

            Console.ReadKey();


        }
    }

}
