using System;

namespace Lecture_3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Task_01();
            //Task_02();
            //Task_03();
            //Task_04();
            Task_05();
            DOB();
        }
        private static void Task_01()
        {
            Console.Write("Side A: ");
            int sideA = int.Parse(Console.ReadLine());

            Console.Write("Side B: ");
            int sideB = int.Parse(Console.ReadLine());

            Console.Write("Side C: ");
            int sideC = int.Parse(Console.ReadLine());

            if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                Console.WriteLine("There are 2 equal sides.");

                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("There are 3 equal sides.");
                    Console.WriteLine("A, B, C are equal.");
                }
                else
                {
                    if (sideA == sideB)
                    {
                        Console.WriteLine("A is equal to B");
                    }
                    else if (sideB == sideC)
                    {
                        Console.WriteLine("B is equal to C");
                    }
                    else
                    {
                        Console.WriteLine("A is equal to C");
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no equal sides");
            }
        }
        private static void Task_02()
        {
            int countOfNumbers = 0;
            int sumOfNumbers = 0;

            for (int counter = 1; counter <= 10; counter++)
            {
                Console.Write($"Please enter number {counter}: ");
                int number = int.Parse(Console.ReadLine());

                if (number <= 20 && number >= 10)
                {
                    countOfNumbers++;
                    sumOfNumbers = sumOfNumbers + number;
                }
            }

            Console.WriteLine($"There are {countOfNumbers} between 10 and 20");
            Console.WriteLine($"Sum of numbers between 10 and 20 is {sumOfNumbers} ");
        }
        private static void Task_03()
        {
            Console.Write($"Please enter your height in cm.: ");
            int height = int.Parse(Console.ReadLine());

            if (height > 190)
            {
                Console.WriteLine("Basketball");
            }
            else if (height > 175)
            {
                Console.WriteLine("Athletics");
            }
            else
            {
                Console.WriteLine("Horse riding");
            }
        }
        private static void Task_04()
        {
            int weekDay = 1;
            int hour = 22;

            string partOfTheDay = GetPartOfTheDay(hour);
            string weekDayName = GetDayOfTheWeek(weekDay);
            string periodToTheWeekend = GetPeriodToTheWeekend(weekDay);

            Console.WriteLine($"Good {partOfTheDay}, it is a lovely {weekDayName} today. {periodToTheWeekend}");
        }

        private static string GetPartOfTheDay(int hour)
        {
            if (hour < 6 || hour > 20)
            {
                return "night";
            }
            else if (hour < 10)
            {
                return "morning";
            }
            else if (hour < 16)
            {
                return "day";
            }
            else
            {
                return "evening";
            }
        }

        private static string GetPeriodToTheWeekend(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return $"Weekend is coming in {6 - dayNumber}";

                case 6:
                case 7:
                    return "Weekend is here";

                default:
                    return "It is knknown time of the week";
            }
        }

        private static string GetDayOfTheWeek(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default: return "Error!";
            }
        }

        private static void Task_05()
        {
           
            Console.Write("Please enter First name: ");
            string first_name = Console.ReadLine();

            Console.Write("Please enter Last name: ");
            string last_name = Console.ReadLine();

            if (first_name.Length <= 100 && last_name.Length <= 100)
            {
                Console.Write("Welcome " + first_name + " " + last_name);
            }
            else
            {
                Console.Write(" ERROR! please enter appropraite names. Both names have to be less than 100 words");
                Console.ReadKey();

            }
        }

        private static void DOB()
        {
            Console.Write("\n\n");
            Console.Write(" please enter year of birth: ");
            int YOB;
            YOB = int.Parse(Console.ReadLine());

            if (YOB < 2020 && YOB > 1920)
            {
                Console.Write(" please enter month of birth: ");
                string month = Console.ReadLine();

                Console.Write(" please enter day of birth: ");
                int day = int.Parse(Console.ReadLine());

                Console.Write("I see you were born on the " + day + "th of " + month + " " + YOB);
            }
            else if ((YOB < 1920) || (YOB > 2020))
            {
                Console.Write("You must be less than 100 years or at least 0 year old ");
                Console.Write("\n");
                DOB();
            }
            
                
            Console.Write("\n");
            Console.Write(" please enter Student number in this format YYYYFFSSNNNN : ");
            string student_num = Console.ReadLine();

            if(student_num.Length == 12)
            {
                bool check = false;
                while (check == false)
                {
                    int count = 0;
                    if ((int.Parse(student_num[4].ToString()) > 9) || (int.Parse(student_num[4].ToString()) == 0))
                    {
                        Console.Write("Wrong faculty number");
                        Console.Write("\n");
                        count++;
                    }
                    if ((int.Parse(student_num[5].ToString()) > 9) || (int.Parse(student_num[5].ToString()) == 0))
                    {
                        Console.Write("Wrong faculty number");
                        Console.Write("\n");
                        count++;
                    }
                    if ((int.Parse(student_num[6].ToString()) > 5) || (int.Parse(student_num[6].ToString()) == 0))
                    {
                        Console.Write("Wrong specialty number");
                        Console.Write("\n");
                        count++;
                    }
                    if ((int.Parse(student_num[7].ToString()) > 5) || (int.Parse(student_num[7].ToString()) == 0))
                    {
                        Console.Write("Wrong specialty number");
                        Console.Write("\n");
                        count++;
                    }
                    if( count > 0)
                    {
                        check = false;
                    }
                    else { check = true; }
                }
            }
            else
            {
                while (student_num.Length != 12)
                {
                    Console.Write("Please enter 12 digit student number :");
                    student_num = Console.ReadLine();
                }
            }

        }

    }
}
