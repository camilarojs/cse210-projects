using System;

class CheckList : BaseGoal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckList() : base()
    {
        _amountCompleted = 0;
        _target = 0;
        _bonus = 0;
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public override void CreateGoal()
    {
        SetNameFromConsole();
        SetDescriptionFromConsole();
        SetNumberOfPointsFromConsole();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (IsComplete())
        {
            return GetNumberOfPoints() + _bonus;
        }
        return GetNumberOfPoints();
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDisplayString()
    {
        return base.GetDisplayString() + $" -- Completed: {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckList:{GetName()},{GetDescription()},{GetNumberOfPoints()},{_amountCompleted},{_target},{_bonus}";
    }
}