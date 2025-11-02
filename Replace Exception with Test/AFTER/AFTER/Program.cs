using System;

class DataAnalyzer
{
    private double[] values = { 10.5, 20.0, 30.25 };

    public double GetValueForPeriod(int periodNumber)
    {
        if (periodNumber < 0 || periodNumber >= values.Length)
        {
            Console.WriteLine("Error: Period number out of range!");
            return 0;
        }

        return values[periodNumber];
    }
}

class Program
{
    static void Main()
    {
        DataAnalyzer analyzer = new DataAnalyzer();
        Console.WriteLine(analyzer.GetValueForPeriod(5)); // Giờ không ném exception nữa
    }
}
