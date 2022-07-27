using NUnit.Framework;

namespace Be.Gilit.CalculateStatsKata.Tests;

public class CalculateStatsShould
{

    [Test, Sequential]
    public void ProvideMinValueOfARange([Values( new[]{6, 9, 15, -2, 92, 11}, new[]{5,4,5} )]int[] range, [Values(-2,4)] int expectedResult)
    {
        var calculateStats = new CalculateStats(range);
        Assert.That(calculateStats.GetMin(), Is.EqualTo(expectedResult));
    }

    [Test, Sequential]
    public void ProvideMaxValue([Values( new[]{6, 9, 15, -2, 92, 11}, new[]{5,4,5} )]int[] range, [Values(92,5)] int expectedResult)
    {
        var calculateStats = new CalculateStats(range);
        Assert.That(calculateStats.GetMax(), Is.EqualTo(expectedResult));
    }
    
    [Test, Sequential]
    public void ProvideTotalNumberOfElements([Values( new[]{6, 9, 15, -2, 92, 11}, new[]{5,4,5} )]int[] range, [Values(6,3)] int expectedResult)
    {
        var calculateStats = new CalculateStats(range);
        Assert.That(calculateStats.GetTotalNumbers(), Is.EqualTo(expectedResult));
    }
    
    [Test, Sequential]
    public void ProvideAverageValue([Values( new[]{6, 9, 15, -2, 92, 11}, new[]{5,4,5} )]int[] range, [Values(21.833333333333332,4.666666666666667)] double expectedResult)
    {
        var calculateStats = new CalculateStats(range);
        Assert.That(calculateStats.GetAverage(), Is.EqualTo(expectedResult));
    }
}