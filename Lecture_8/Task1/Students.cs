using System;
namespace Lecture_8.Task1
{
    public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {age} years old");
        }
    }
}
