public class Swimming : Activity
{
    private int _laps;

    public Swimming(int duration, int laps) : base(duration)
    {
        this._laps = laps;
    }

    public override double GetDistance() {
        return Math.Round(_laps * 50.0 / 1000.0, 2);
    }
    public override double GetSpeed() {
        return Math.Round(GetDistance() / (GetDuration() / 60.0), 2);
    }
    public override double GetPace() {
        return Math.Round(GetDuration() / GetDistance(), 2);
    }
}