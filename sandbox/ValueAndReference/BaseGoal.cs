

abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    protected void SetName()
    {
        Console.Write("What is the name of the goal: ");
        _name = Console.ReadLine();
    }

    protected void SetDescription()
    {
        Console.Write($"Enter the description for {_name} goal: ");
        _description = Console.ReadLine();
    }

    protected void SetNumberOfPoints()
    {
        Console.Write($"Enter the points earned for {_name} goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }


    // Format and return a string can be used to display status the goal.
    public virtual string GetDisplayString()
    {
        // If this goal is complete, place an X in the status location.
        char statusMarker = ' ';
        if (_status)
        {
            statusMarker = 'X';
        }
        return $"[ ] Name: {_name}, Description: {_description}, points earned: {_numberOfPoints}"; 
    }

    /*I 
    MarkComplete will set the status to true, which means complete 
    and return the number of points for completing goal.
    */

    protected int MarkComplete()
        {
            _status = true;
            return _numberOfPoints;
        }

    public abstract void CreateGoal();
    public abstract void RecordEvent();

}