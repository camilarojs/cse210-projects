using System;
using System.Collections.Generic;
using System.IO;

class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();
    private int _score = 0;

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string type = Console.ReadLine();

                BaseGoal newGoal = null;
                if (type == "1")
                {
                    newGoal = new Simple();
                }
                else if (type == "2")
                {
                    newGoal = new Eternal();
                }
                else if (type == "3")
                {
                    newGoal = new CheckList();
                }

                if (newGoal != null)
                {
                    newGoal.CreateGoal();
                    _goals.Add(newGoal);
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("The goals are:");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
                }
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                
                using (StreamWriter file = new StreamWriter(filename))
                {
                    file.WriteLine(_score);
                    foreach (BaseGoal g in _goals)
                    {
                        file.WriteLine(g.GetStringRepresentation());
                    }
                }
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                
                if (File.Exists(filename))
                {
                    _goals.Clear();
                    
                    // Exactly like the Code Helps example: Read lines into an array
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    
                    // The first line is just the score
                    _score = int.Parse(lines[0]);

                    // Start loop at 1 to skip the score line
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        
                        // Split line by colon to get Type and Details
                        string[] parts = line.Split(':');
                        string goalType = parts[0];
                        string details = parts[1];

                        // Split details by comma exactly like Code Helps example: parts[0], parts[1]
                        string[] props = details.Split(',');

                        if (goalType == "Simple")
                        {
                            Simple s = new Simple();
                            s.SetName(props[0]);
                            s.SetDescription(props[1]);
                            s.SetNumberOfPoints(int.Parse(props[2]));
                            s.SetStatus(bool.Parse(props[3]));
                            _goals.Add(s);
                        }
                        else if (goalType == "Eternal")
                        {
                            Eternal e = new Eternal();
                            e.SetName(props[0]);
                            e.SetDescription(props[1]);
                            e.SetNumberOfPoints(int.Parse(props[2]));
                            _goals.Add(e);
                        }
                        else if (goalType == "CheckList")
                        {
                            CheckList c = new CheckList();
                            c.SetName(props[0]);
                            c.SetDescription(props[1]);
                            c.SetNumberOfPoints(int.Parse(props[2]));
                            c.SetAmountCompleted(int.Parse(props[3]));
                            c.SetTarget(int.Parse(props[4]));
                            c.SetBonus(int.Parse(props[5]));
                            _goals.Add(c);
                        }
                    }
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine();
                Console.WriteLine("The goals are:");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
                }
                Console.Write("Which goal did you accomplish? ");
                int idx = int.Parse(Console.ReadLine()) - 1;

                int earned = _goals[idx].RecordEvent();
                _score += earned;
                Console.WriteLine($"Congratulations! You have earned {earned} points!");
            }
        }
    }
}