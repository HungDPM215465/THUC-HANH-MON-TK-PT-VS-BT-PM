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
        return 0.1;
    }

    public double GetFees()
    {
        return 5.0;
    }

    // 🔽 Method now calls query methods directly, no need for parameters
    public double DiscountedPrice(double basePrice)
    {
        return basePrice - (basePrice * GetSeasonDiscount()) + GetFees();
    }

    public double GetFinalPrice()
    {
        int basePrice = quantity * (int)itemPrice;
        double finalPrice = DiscountedPrice(basePrice);
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
