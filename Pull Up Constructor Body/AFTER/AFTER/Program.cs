using System;

class Employee
{
    protected string name;
    protected string id;

    public Employee(string name, string id)
    {
        this.name = name;
        this.id = id;
    }
}

class Manager : Employee
{
    private string grade;

    public Manager(string name, string id, string grade)
        : base(name, id) // Gọi constructor của superclass
    {
        this.grade = grade;
    }
}

class Engineer : Employee
{
    private string level;

    public Engineer(string name, string id, string level)
        : base(name, id)
    {
        this.level = level;
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager("Alice", "M01", "A");
        Engineer e = new Engineer("Bob", "E05", "Senior");

        Console.WriteLine($"{m.GetType().Name}: {m}");
        Console.WriteLine($"{e.GetType().Name}: {e}");
    }
}
