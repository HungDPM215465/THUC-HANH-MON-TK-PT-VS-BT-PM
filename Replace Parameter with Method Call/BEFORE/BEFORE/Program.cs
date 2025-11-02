using System;

class Order
{
    private int quantity;
    private double itemPrice;

    public Order(int quantity, double itemPrice)
    {
        this.quantity = quantity;
        this.itemPrice = itemPrice;
    }

    public double GetSeasonDiscount()
    {
        return 0.1; // 10% seasonal discount
    }

    public double GetFees()
    {
        return 5.0; // fixed shipping or service fee
    }

    public double DiscountedPrice(double basePrice, double seasonDiscount, double fees)
    {
        return basePrice - (basePrice * seasonDiscount) + fees;
    }

    public double GetFinalPrice()
    {
        int basePrice = quantity * (int)itemPrice;
        double seasonDiscount = this.GetSeasonDiscount();
        double fees = this.GetFees();

        // Passing computed values as parameters 👇
        double finalPrice = DiscountedPrice(basePrice, seasonDiscount, fees);
        return finalPrice;
    }
}

class Program
{
    static void Main()
    {
        Order order = new Order(10, 20.0);
        Console.WriteLine($"Final Price: {order.GetFinalPrice()}");
    }
}
