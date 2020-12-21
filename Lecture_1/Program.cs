using System;

namespace Lecture_1 {

    class Program
    {
        static void Main(string[] args)
        {
            MeAfter10();
            SimpleFormulas();
            Task3_Dates();
            Task4_FutureBDay();


        }
     private static void MeAfter10()
        {
            Console.Write(" please enter your age: ");
             string ageAsString = Console.ReadLine();

            try
            {

                int ageAsint = int.Parse(ageAsString);
                int ageAfter10 = ageAsint + 10;

                Console.WriteLine("Your age after 10 years will be (ageAfter10) years");
            }
            catch
            {
                Console.WriteLine("ERROR. Please enter correct age");
            }
        }
        private static void SimpleFormulas ()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("---------");

            Console.Write(" please enter side A: ");
            int sideA = int.Parse(Console.ReadLine());


            Console.Write(" please enter side B: ");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Area = " +sideA * sideB);

            Console.WriteLine("Perimeter = " + 2 * (sideA + sideB));

            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Triangle");
            Console.WriteLine("---------");

            Console.Write(" please enter side A: ");
            sideA = int.Parse(Console.ReadLine());


            Console.Write(" please enter side B: ");
            sideB = int.Parse(Console.ReadLine());

            Console.Write(" please enter side B: ");
            int sideC = int.Parse(Console.ReadLine());

            Console.Write(" please enter height: ");
            int height = int.Parse(Console.ReadLine());


            Console.WriteLine("Area = " + sideA * height);

            Console.WriteLine("Perimeter =" + (sideA + sideB + sideC));

            Console.ReadKey();

        }
        private static void Task3_Dates()
        {
            DateTime date = DateTime.Now;

            Console.Write(" Current date: ");
            Console.WriteLine(date.ToShortDateString());

            Console.Write(" Current time: ");
            Console.WriteLine(date.ToShortDateString());

            Console.Write(" DAte after 1rs0 yea: ");
            Console.WriteLine(date.Addyears(10).ToShortDateString());

            Console.Write("PLease enter a period: ");
            int period = int.Parse(Console.ReadLine());

            Console.Write($"Date after (period) years: ");
        }

        private static void Task4_FutureBDay()
        {
            Console.Write(" Current age: ");
            int currentAge = int.Parse(Console.ReadLine());


            Console.Write(" Future age: ");
            int futureAge = int.Parse(Console.ReadLine());

            Console.Write(" BDay month: ");
            int bdayMonth = int.Parse(Console.ReadLine());

            Console.Write(" BDay day: ");
            int bdayDay = int.Parse(Console.ReadLine());

            int ageDifference = futureAge - currentAge;
            int futureYear = DateTime.Now.Year + ageDifference;

            var futureBDay = new DateTime(futureYear, bdayMonth, bdayDay);
            Console.Write(" ");

            Console.ReadKey();


        }



    }
}
