using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);
        string letter = "";
        string PassFail = "";

        if(grade >= 90){
            letter = "A";
        }
        else if(grade >=80){
            letter = "B";
        }
        else if(grade >=70){
            letter = "C";
        }
        else if(grade >=60){
            letter = "D";
        }
        else{
            letter = "F";
        }

        if(grade >= 70){
            PassFail = "you passed the class!";
        }

        else{
            PassFail = "you didn't pass. Better luck next time!";
        }
        
        Console.WriteLine($"Your final grade is a/an {letter} and {PassFail}");
    }
}
