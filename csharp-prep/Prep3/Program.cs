using System;

class Program
{
    static void Main(string[] args)
    {        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        string match = "no";

        do{
            Console.Write("What is your guess? ");
            string num = Console.ReadLine();
            int guess = int.Parse(num);
            
            if(guess == number){
                Console.WriteLine("You guessed it!");
                match = "yes";
            }
            else if(guess > number){
                Console.WriteLine("Lower");

            }
            else{
                Console.WriteLine("Higher");
            }
          } while(match == "no");
    } 

}
