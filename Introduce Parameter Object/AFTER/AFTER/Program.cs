using System;

class DateRange
{
    public DateTime Start { get; }
    public DateTime End { get; }

    public DateRange(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }
}

class Customer
{
    public double AmountInvoicedIn(DateRange range)
    {
        Console.WriteLine($"Calculating invoiced amount from {range.Start.ToShortDateString()} to {range.End.ToShortDateString()}");
        return 1000.0;
    }

    public double AmountReceivedIn(DateRange range)
    {
        Console.WriteLine($"Calculating received amount from {range.Start.ToShortDateString()} to {range.End.ToShortDateString()}");
        return 800.0;
    }

    public double AmountOverdueIn(DateRange range)
    {
        Console.WriteLine($"Calculating overdue amount from {range.Start.ToShortDateString()} to {range.End.ToShortDateString()}");
        return 200.0;
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer();
        DateRange quarter1 = new DateRange(new DateTime(2025, 1, 1), new DateTime(2025, 3, 31));

        customer.AmountInvoicedIn(quarter1);
        customer.AmountReceivedIn(quarter1);
        customer.AmountOverdueIn(quarter1);
    }
}
