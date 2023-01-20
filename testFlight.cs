using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome.....\n\n\n");
        Factorial();
        Method();

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
    public static void Method()
    {
        Console.WriteLine("\n\n\n******************CONVERT TO HEXCODE******************");
        Console.WriteLine("Ready to convert your name to a Hex code ? Yes or No: ");
        string? userInput = Console.ReadLine()!.ToUpper();
        if(userInput == "YES") { 
            Console.WriteLine("Enter your name: ");
            string? name = Console.ReadLine();
            byte[] bytes = Encoding.UTF8.GetBytes(name!); //"!" means that the "name" variable will always have a value.
            string hexCode = Convert.ToHexString(bytes);
            string finalCode = hexCode.Replace("20", " ");
            Console.WriteLine($"String: {name} , hexCode: {finalCode}");
        }
        else
        {
            Console.WriteLine("Okay, we get you dont want your name to be intersting.. seeya ");
        }
    }
}
