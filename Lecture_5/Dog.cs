using System;


namespace Lecture_5
{
    public class Dog
    {
        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}
