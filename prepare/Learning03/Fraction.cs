public class Fraction {
    private int _top;
    private int _bottom;
    public Fraction() {
        this._top = 1;
        this._bottom = 1;
    }
    public Fraction(int top) {
        this._top = top;
        this._bottom = 1;
    }
    public Fraction(int top, int bottom) {
        this._top = top;
        this._bottom = bottom;
    }

    public int getTop() {
        return this._top;
    }
    public void setTop(int top) {
        this._top = top;
    }
    public int getBottom() {
        return this._bottom;
    }
    public void setBottom(int bottom) {
        this._top = bottom;
    }
    public string GetFractionString() {
        return this._top + "/" + this._bottom;
    }
    public decimal GetDecimalValue() {
        return (decimal)this._top / this._bottom;
    }
}