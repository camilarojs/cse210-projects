using System;

abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetNumberOfPoints()
    {
        return _numberOfPoints;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetNumberOfPoints(int points)
    {
        _numberOfPoints = points;
    }

    protected void SetNameFromConsole()
    {
        Console.Write("What is the name of the goal: ");
        _name = Console.ReadLine();
    }

    protected void SetDescriptionFromConsole()
    {
        Console.Write($"Enter the description for {_name} goal: ");
        _description = Console.ReadLine();
    }

    protected void SetNumberOfPointsFromConsole()
    {
        Console.Write($"Enter the points earned for {_name} goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public virtual string GetDisplayString()
    {
        string statusMarker = " ";
        if (IsComplete())
        {
            statusMarker = "X";
        }
        return $"[{statusMarker}] Name: {_name}, Description: {_description}, points earned: {_numberOfPoints}"; 
    }

    public abstract void CreateGoal();
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
}