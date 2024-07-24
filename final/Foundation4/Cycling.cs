public class Cycling : Activity
{
    private double _speed; 

    public Cycling(int duration, double speed) : base(duration)
    {
        this._speed = speed;
    }

    public override double GetDistance() {
        return Math.Round((_speed * GetDuration()) / 60, 2);
    }
    public override double GetSpeed() {
        return _speed;
    }
    public override double GetPace(){
        return 60 / _speed;
    }
}