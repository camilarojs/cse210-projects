using System;

// Creativity Description:
// For the creativity part, I made the random hiding system a bit smarter. 
// Instead of picking words completely at random and accidentally selecting words that are already blanked out, 
// it filters them first so it only hides words you can actually still see. 
// I also added .ToLower() to the input so if a user types 'QUIT' or 'Quit' in all caps, it still registers it perfectly.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";

        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            scripture.DisplayScripture();

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine("Good job! You have hidden the entire scripture.");
        }
    }
}