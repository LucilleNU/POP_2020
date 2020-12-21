using System;

namespace Lecture_2
{
    class Program
    {
        static void Main(string[] args)
        {
            HW1_quest1();
            HW1_quest2();
            HW1_quest3();
            HW2_quest4();
            HW2_quest5();
            HW2_quest6();
            HW2_quest7();
        }


        private static void HW1_quest1()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Lucille");
        }

        private static void HW1_quest2()
        {
            int a = 5;
            int b = 6;
            int c = a + b;
            Console.WriteLine("Sum = " + (c)); //Sum = 11
            Console.ReadKey();
            Console.Write("\n\n");

        }

        private static void HW1_quest3()
        {
            Console.WriteLine("First Operation: " + -1 + 4 * 6);
            Console.ReadLine();

            Console.WriteLine("Second Operation: " + (35 + 5) % 7);
            Console.ReadLine();

            Console.WriteLine("Third Operation: " + 14 + -4 * 6 / 11);
            Console.ReadLine();

            Console.WriteLine("Fourth Operation: " + 2 + 15 / 6 * (1 - 7 % 2));
            Console.ReadLine();
            Console.Write("\n\n");
        }

        private static void HW2_quest4()
        {
            Console.Write(" please enter First number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write(" please enter Second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write(" please enter Third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplication of 3 numbers = " + num1 * num2 * num3);
            Console.ReadKey();
            Console.Write("\n\n");
        }

        private static void HW2_quest5()
        {
            int j, n;
            Console.Write("Display the multiplication table:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number (Table to be calculated) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
            Console.Write("\n\n");
        }

        private static void HW2_quest6()
        {
            Console.Write(" please enter First number: ");
            int av1= int.Parse(Console.ReadLine());

            Console.Write(" please enter Second number: ");
            int av2 = int.Parse(Console.ReadLine());

            Console.Write(" please enter Third number: ");
            int av3 = int.Parse(Console.ReadLine());

            Console.Write(" please enter Fourth number: ");
            int av4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Average of numbers = " + (av1 + av2 + av3 + av4)/4);
            Console.ReadKey();
            Console.Write("\n\n");

        }
        private static void HW2_quest7()
        {

        }

    }

}