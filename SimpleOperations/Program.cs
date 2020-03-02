using System;

// Page 159

namespace SimpleOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perform some random operations!\n");
            System.Threading.Thread.Sleep(1000);

            Operations ops = new Operations();

            bool play = true;
            while (play)
            {
                // Enter an integer
                bool intInvalid = true;
                while (intInvalid)
                {
                    Console.Write("Enter an integer that you want to perform math on: ");
                    try
                    {
                        int userInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The square of {0} is {1}\n", userInt, ops.Mathematics(userInt));
                        System.Threading.Thread.Sleep(1000);
                        intInvalid = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Your number needs to be an interger!\n");
                    }
                    catch (Exception e)
                    {
                        Console.Write("Something went wrong... ");
                        Console.WriteLine(e.GetType());
                    }
                }

                // Enter a decimal
                bool decimalInvalid = true;
                while (decimalInvalid)
                {
                    Console.Write("Enter a decimal that you want to perform math on: ");
                    try
                    {
                        double userDouble = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The square root of {0} is {1}...ish\n", userDouble, ops.Mathematics(userDouble));
                        System.Threading.Thread.Sleep(1000);
                        decimalInvalid = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Your number needs to be a double!\n");
                    }
                    catch (Exception e)
                    {
                        Console.Write("Something went wrong... ");
                        Console.WriteLine(e.GetType());
                    }
                }

                // Enter a string
                Console.Write("Enter an int or a decmial: ");
                string userString = Console.ReadLine();
                Console.WriteLine("The number {0} times PI is {1}...ish\n", userString, ops.Mathematics(userString));

                // Play again text
                Console.Write("Do you want to go again? (y or n) ");
                string playAgainChoice = Console.ReadLine();
                if (playAgainChoice != "y")
                {
                    play = false;
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Have a good day!");
            Console.ReadLine();
        }
    }
}
