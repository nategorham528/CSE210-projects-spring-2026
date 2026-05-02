using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int num = 1000;
        int sum = 0;
        float average = 0;
        int largest = 0;
        int smallest = 1000000000;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(num != 0){
            if(num != 0){
                Console.Write("Enter Number: ");
                string enter = Console.ReadLine();
                num = int.Parse(enter);
                numbers.Add(num);
            }
        }

        foreach(int number in numbers){
            sum += number;
            if(number > largest){
                largest = number;
            }
            else if(number < smallest && number > 0){
                smallest = number;
            }
        } 
        average = (float)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest positive number: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
    }
}
