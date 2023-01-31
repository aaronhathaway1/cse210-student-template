using System;
using System.IO;

namespace Journaling
{
    class Prompt
    {

        public string PromptExplicit = "";
        int userPrompt = 0;

        public string arrangePrompt()
        {
            userPrompt = getPromptNum();
            if (userPrompt == 1)
            {
                PromptExplicit = createPrompt();
                // Console.WriteLine(userPrompt);
            }
            else
            {
                PromptExplicit = "Opted for no prompt";

            }

            return PromptExplicit;
        }

        int getPromptNum()
        {
            int promptNum = 0;

            while (promptNum != 1 && promptNum != 2)
            {
                Console.WriteLine("Do you want a prompt today?");
                Console.WriteLine("1. Yes, absolutely.");
                Console.WriteLine("2. No, thank you.");
                promptNum = int.Parse(Console.ReadLine());
            }

            return promptNum;
        }

        string createPrompt()
        {
            Random rnd = new Random();
            int promptIndex = rnd.Next(1, 30);
            string[] prompts = {

            "Write about something you are grateful for today.",
            "Reflect on a challenge you faced today and how you overcame it.",
            "Describe your perfect day today.",
            "What values guide you today?",
            "Think of someone who influenced you today and write about them.",
            "Write about a moment of self-discovery you had today.",
            "Think of a place that holds special meaning to you today and describe it.",
            "Write about something you had to let go of today.",
            "Reflect on a risk you took today and what happened as a result.",
            "Write about a goal you have for today and the steps you plan to take to achieve it.",
            "Think of a moment of kindness you experienced or showed to someone today.",
            "Reflect on a fear you faced today and how you coped.",
            "Write about a memory that came to mind today.",
            "Describe a person who you admire today and why.",
            "Reflect on a lesson you learned today.",
            "Write about a time when you showed resilience today.",
            "Think of a time when you showed generosity today.",
            "Write about a moment of peace you experienced today.",
            "Reflect on a time when you showed empathy today.",
            "Write about a time when you showed determination today.",
            "Think of a moment of inspiration you experienced today.",
            "Reflect on a time when you showed courage today.",
            "Write about a time when you showed compassion today.",
            "Think of a time when you showed forgiveness today.",
            "Reflect on a time when you showed patience today.",
            "Write about a time when you showed understanding today.",
            "Think of a time when you showed love today.",
            "Reflect on a time when you showed hope today.",
            "Write about a time when you showed joy today.",
            "Think of a time when you showed humility today.",
        };

            return prompts[promptIndex - 1];
        }



    }
}