using System;

class Customer
{
    public string Name { get; }

    public Customer(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer("Alice");
        Console.WriteLine(customer.Name); // Alice

        // customer.Name = "Bob"; ❌ Compile-time error (readonly)
    }
}
