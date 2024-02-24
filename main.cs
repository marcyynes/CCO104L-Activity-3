using System;

class Program
{
    static void Main(string[] args)
    {
        int number;

        do
        {
            Console.Write("Enter a non-negative number (enter 0 to exit): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out number) || number < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative number.");
                continue;
            }
            else if (number == 0)
            {
                Console.WriteLine("Exiting the program...");
                return;
            }

            DrawTriangle(number);

        } while (true);
    }

    static void DrawTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}