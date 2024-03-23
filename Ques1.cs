using System;

class Question1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the height of the triangle:");
        int height;
        while (!int.TryParse(Console.ReadLine(), out height) || height < 1)
        {
            Console.WriteLine("The height of the traingle must be greater than 0");
        }

        printTriangle(height);

        Console.ReadLine(); 
    }

    static void printTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            
            for (int j = 0; j < height - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
