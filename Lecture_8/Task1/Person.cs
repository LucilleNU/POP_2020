using System;
namespace Lecture_8.Task1
{
    public class Person
    {
        internal int age;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void Say(string message)
        {
            Console.WriteLine(message);
        }
    }
}
