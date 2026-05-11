using System;

class Program
{

    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int response = -1;

        while (response != magicNumber)
        {
            Console.Write("What is your guess? ");
            response = int.Parse(Console.ReadLine());

            if (response < magicNumber)
                {
                    Console.WriteLine("Higher");
                }   
            else if (response > magicNumber)
                {
                    Console.WriteLine("Lower");
                }      
            else
                {
                    Console.WriteLine("You guessed it!");
                }
        }
    }
}
