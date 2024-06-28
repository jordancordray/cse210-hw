using System.Security;

public abstract class Goal{
    protected string _title;
    protected string _desc;
    protected int _points;
    protected bool _completed;

    public Goal(string title, string desc, int points){
        _title = title;
        _desc = desc;
        _points = points;
        _completed = false;
    }

    public string GetTitle(){
        return _title;
    }

    public int GetPoints(){
        return _points;
    }

    public bool IsCompleted(){
        return _completed;
    }

    public abstract void RecordEvent();

    public abstract void DisplayGoal();

    public abstract string GetStringRepresentation();
}