using System;

class TemperatureRange
{
    private int low;
    private int high;

    public TemperatureRange(int low, int high)
    {
        this.low = low;
        this.high = high;
    }

    public int GetLow() => low;
    public int GetHigh() => high;
}

class HeatingPlan
{
    private int min;
    private int max;

    public HeatingPlan(int min, int max)
    {
        this.min = min;
        this.max = max;
    }

    public bool WithinRange(TemperatureRange range)
    {
        return (range.GetLow() >= min && range.GetHigh() <= max);
    }
}

class Program
{
    static void Main()
    {
        TemperatureRange daysTempRange = new TemperatureRange(20, 26);
        HeatingPlan plan = new HeatingPlan(18, 28);

        bool withinPlan = plan.WithinRange(daysTempRange);
        Console.WriteLine($"Within plan: {withinPlan}");
    }
}
