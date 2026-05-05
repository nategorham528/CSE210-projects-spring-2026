using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string InputName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        int birthYear = PromptUserBirthYear();


        DisplayResult(InputName, squaredNumber, birthYear);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int FavNum = int.Parse(Console.ReadLine());
        return FavNum;
    }

    static int PromptUserBirthYear(){
        Console.Write("Please enter the year you were born: ");
        int birthYear = int.Parse(Console.ReadLine());
        return birthYear;
    }

    static int SquareNumber(int FavNum)
    {
        int NumSquared = FavNum * FavNum;
        return NumSquared;
    }

    static void DisplayResult(string name, int square, int birthYear){
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }
}
