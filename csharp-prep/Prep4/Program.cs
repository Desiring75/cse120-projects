using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //Ask user for a series of numbers, then add them to the list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int userNumber;
        do
        {
            Console.Write("Enter number: ");
            string stringNumber = Console.ReadLine();
            userNumber = int.Parse(stringNumber);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        //Iterate through list to compute sum, average, and maximum
        int sum = 0;
        int maximum = 0;

        //To compare values to find the smallest, we'll grab the first number so we always have a value we can base the comparison
        int positiveMin = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;

            if (maximum < number)
            {
                maximum = number;
            }

            if (number < positiveMin & number > 0)
            {
                positiveMin = number;
            }
        }

        int listSize = numbers.Count;
        float average = ((float)sum) / listSize;

        //Print results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average:G15}");
        Console.WriteLine($"The largest number is: {maximum}");
        Console.WriteLine($"The smallest postive number is: {positiveMin}");


    }
}