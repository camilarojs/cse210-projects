using System;
using System.Collections.Generic;
using System.Threading;

class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How many seconds for this activity? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowLoading(3);
        Console.WriteLine();
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowLoading(3);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowLoading(3);
    }

    public void ShowLoading(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message} ");
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}