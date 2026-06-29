class Simple : BaseGoal
{
    private bool _status;

    public Simple() : base()
    {
        _status = false;
    }

    public void SetStatus(bool status)
    {
        _status = status;
    }

    public override void CreateGoal()
    {
        SetNameFromConsole();
        SetDescriptionFromConsole();
        SetNumberOfPointsFromConsole();
    }

    public override int RecordEvent()
    {
        _status = true;
        return GetNumberOfPoints();
    }

    public override bool IsComplete()
    {
        return _status;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple:{GetName()},{GetDescription()},{GetNumberOfPoints()},{_status}";
    }
}