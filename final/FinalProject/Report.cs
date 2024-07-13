class Report{
    private string _title;
    private string _desc;
    private DateTime _date;

    public Report(string title, string desc){
        _title = title;
        _desc = desc;
        _date = DateTime.Now;
    }

    public string GetTitle(){
        return _title;
    }
    public string GetDesc(){
        return _desc;
    }
    public DateTime GetDate(){
        return _date;
    }

}