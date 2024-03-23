using System;
using System.Text.RegularExpressions;

class Question2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string date = findValidDate(input);

        if (date != null)
        {
            Console.WriteLine("Output: " + date);
        }
        else
        {
            Console.WriteLine("No valid date found in the string.");
        }

        Console.ReadLine(); 
    }

    static string findValidDate (string input)
    {
        Regex regex = new Regex(@"\b(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])(19|20)\d{2}\b");
        Match match = regex.Match(input);
        if (match.Success)
        {
            return match.Value;
        }
        return null;
    }
}
