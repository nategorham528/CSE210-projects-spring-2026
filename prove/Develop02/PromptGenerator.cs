using System;

public class PromptGenerator
{

    public string promptOptionsNG(int numNG){
        List<string> promptList = new List<string>();
        promptList.Add("What was the highlight of your day?");
        promptList.Add("What is one moment from today that made you feel genuinely happy, and why did it affect you so strongly?");
        promptList.Add("What are five things you are grateful for today, and why do they matter to you?");
        promptList.Add("What is something you accomplished today?");
        promptList.Add("What is something you wish you had done differently today?");
        promptList.Add("What is something you are looking forward to tomorrow?");
        promptList.Add("What distracted you the most today?");
        promptList.Add("What is one thing you did today that future-you will appreciate?");
        promptList.Add("What challenged you the most today, and how did you respond?");
        promptList.Add("What drained your energy today, and what gave you energy?");

        string promptNG = promptList[numNG];

        return promptNG;
    }


    public int numGeneratorNG(){
        Random randomNG = new Random();
        int numNG = randomNG.Next(0,10);
        return numNG;
    }

}
