using System;

namespace Lecture_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //StarTriangle();
            //Diamond();
            HW_1();
            HW_2();

        }
        private static void StarTriangle() 
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("* ");
                }
                Console.ReadLine();
            }
        }
        private static void Diamond()
        {
            int i, j, r;

            Console.Write("\n\n");
            Console.Write("Display the pattern like diamond:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows (half of the diamond) :");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
        private static void HW_1()
        {
            Console.WriteLine("Input the highest number you want the pyramid to reach. (34 is the max good looking value)");
            Console.Write("(Note that to reach the assigned output from the homework you can input 5): ");
            int response = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            string[] a_out = new string[response];
            string[] a_reverse = new string[response];
            string[] a_backwards = new string[response - 1];

            int index;

            for (int counter = 0; counter < response; counter++)
            {
                index = counter; // index will identify the middle value of every column
                for (int num = response - 1; num > -1; num--, index--) //constructs a single row.
                {
                    if (index <= 0)
                    {
                        a_out[num] = " ";
                    }
                    else
                    {
                        a_out[num] = Convert.ToString(index);
                    }

                }
                string result = string.Join("", a_out); //to convert array to string for printing
                Array.Reverse(a_out);
                string result_reverse = string.Join("", a_out);
                Console.WriteLine(result + Convert.ToString(counter + 1) + result_reverse);
                if (counter != response - 1)
                {
                    a_backwards[counter] = result + Convert.ToString(counter + 1) + result_reverse;
                }
            }
            Array.Reverse(a_backwards);
            foreach (string i in a_backwards)
            {
                Console.WriteLine(i);
            }
        }
      
        
        private static void HW_2()
        {
            Console.Write("String to encode: ");
            string stringToEncode = Console.ReadLine();

            string encodedString = Encode(stringToEncode);
            Console.WriteLine($"Encoded string: {encodedString}");

            string decodedString = Decode(encodedString);
            Console.WriteLine($"Decoded string: {decodedString}");
        }

        private static char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
        private static char[] secret = { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a', };

        private static string Encode(string inputString)
        {
            string result = "";
            foreach (char character in inputString)
            {
                int index = IndexOf(character, alpha);
                result += secret[index];
            }
            return result;
        }

        private static string Decode(string encodedString)
        {
            string result = "";
            foreach (char character in encodedString)
            {
                int index = IndexOf(character, secret);
                result += alpha[index];
            }
            return result;
        }

        private static int IndexOf(char letter, char[] array)
        {
            for (int i = 0; i < alpha.Length; i++)
            {
                if (array[i] == letter)
                {
                    return i;
                }
            }
            return -1;
        }
    }
 
    
}
