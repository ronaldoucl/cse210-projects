public abstract class Activity
{
    private string _date;
    private int _duration; 

    protected Activity(int duration)
    {
        this._date = DateTime.Now.ToString("yyyy-MM-dd");
        this._duration = duration;
    }

    public string GetDate () {
        return _date;
    }
    public void SetDate(string date) {
        _date = date;
    }
    public int GetDuration() {
        return _duration;
    }
    public void SetDuration(int duration) {
        _duration = duration;
    }
    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();     

    public virtual string GetSummary()
    {
        return $"{_date} - {GetType().Name} ({_duration} min): " +
               $"Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}