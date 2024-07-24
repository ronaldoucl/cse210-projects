public class Running : Activity
{
    private double _distance; 

    public Running(int duration, double distance) : base(duration)
    {
        this._distance = distance;
    }

    public override double GetDistance() {
        return Math.Round(_distance, 2);
    }
    public override double GetSpeed() {
        return Math.Round((_distance / GetDuration()) * 60, 2);
    }
    public override double GetPace() {
        return Math.Round(GetDuration() / _distance, 2);
    }
}