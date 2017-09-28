using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string ans;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Hello " + name + "!");
            do
            {
                Console.WriteLine();

                Console.Write("Please enter a number between 1 and 100: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if ((userInput < 1) || (userInput > 100))
                {
                    Console.WriteLine();
                    Console.WriteLine(name + ", the number must be between 1 and 100");
                    counter++;

                    if (counter == 3)
                    {
                        Console.WriteLine("Sorry " + name + ", you entered the wrong value too many times. Goodbye.");
                        break;
                    }
                }
                else
                {
                    evaluateNum(userInput);
                }
                Console.WriteLine();
                Console.Write("Enter another number? (Y/N): ");
                ans = Console.ReadLine();
            } while (ans.Equals("Y"));

            Console.ReadKey();
        }


        public static void evaluateNum(int n)
        {
            int userInput = n;

            if ((userInput % 2 == 1) && (userInput < 60))
            {
                Console.WriteLine("Odd");
            }
            else if ((userInput % 2 == 0) && (userInput >= 2) && (userInput < 25))
            {
                Console.WriteLine("Even and less than 25");
            }
            else if ((userInput % 2 == 0) && (userInput >= 26) && (userInput <= 60))
            {
                Console.WriteLine("Even");
            }
            else if ((userInput % 2 == 0) && (userInput >= 60))
            {
                Console.WriteLine(userInput + ":" + "Even");
            }
            else if ((userInput % 2 == 1) && (userInput > 60))
            {
                Console.WriteLine(userInput + ":" + " Odd & over and 60");
            }
        }

    }
}
