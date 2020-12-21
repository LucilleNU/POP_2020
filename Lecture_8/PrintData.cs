using System;
namespace Lecture_8
{
    internal class Printdata
    {
        internal void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        internal void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        internal void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }
}
