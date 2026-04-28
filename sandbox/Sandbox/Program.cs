using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello");
        // int x = 10;
        // if (x == 11)
        // {
        //     Console.WriteLine("Hey bob");
        //     Console.WriteLine("Hey Betty");
        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }
        // Console.WriteLine(i);

        int age = -1;

        while (age < 0 || age > 125)
        {
            Console.WriteLine("Please enter your age: ");
            age = int. Parse(Console.ReadLine());
        }

        int age2;

        do
        {
            Console.WriteLine("Please enter your age: ");
            age2 = int. Parse(Console.ReadLine());
            while (age2 < 0 || age2 > 125);
        }
    }
}

//      //This is a super duper cool comment.
//      //another comment
//      //Console.WriteLine("Hello Sandbox World!");