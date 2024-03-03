using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        int numberEntered = 0;
        do
        {
            Console.Write("Enter number: ");
            numberEntered = int.Parse(Console.ReadLine ());
            numbers.Add(numberEntered);
        } while (numberEntered !=0);
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = (float)sum / (numbers.Count-1);
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number>largest)
            {
                largest=number;
            }
            else
            {

            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}