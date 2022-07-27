namespace Be.Gilit.CalculateStatsKata;

public class CalculateStats
{
    private readonly int[] _range;

    public CalculateStats(int[] range)
    {
        _range = range;
    }

    public int GetMin()
    {
        return _range.Min();
    }

    public int GetMax()
    {
        return _range.Max();
    }

    public int GetTotalNumbers()
    {
        return _range.Length;
    }

    public double GetAverage()
    {
        return _range.Average();
    }
}