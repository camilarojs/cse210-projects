class Eternal : BaseGoal
{
    public Eternal() : base() { }

    public override void CreateGoal()
    {
        SetNameFromConsole();
        SetDescriptionFromConsole();
        SetNumberOfPointsFromConsole();
    }

    public override int RecordEvent()
    {
        return GetNumberOfPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal:{GetName()},{GetDescription()},{GetNumberOfPoints()}";
    }
}