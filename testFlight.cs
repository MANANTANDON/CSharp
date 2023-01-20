using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome.....\n\n\n");
        Factorial();

    }


    public static void Factorial()
    {
        Console.WriteLine("**********FACTORIAL OF A NUMBER**********");
        string userInput = " ";
        do
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"factorial of {num} is : {factorial}");
            do
            {
                Console.WriteLine("Do you go again? : Yes - No :- ");
                userInput = Console.ReadLine().ToUpper();
                if (userInput != "YES" && userInput != "NO")
                {
                    Console.WriteLine("Please enter a valid input! ");
                }
            } while (userInput != "YES" && userInput != "NO");

            } while (userInput == "YES");
    }
}
