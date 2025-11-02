using System;

namespace ReplaceConditional_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Engineer("John");
            Employee emp2 = new Manager("Mary");
            Employee emp3 = new Sales("Tom");

            Console.WriteLine($"{emp1.Name} Bonus: {emp1.GetBonus()}");
            Console.WriteLine($"{emp2.Name} Bonus: {emp2.GetBonus()}");
            Console.WriteLine($"{emp3.Name} Bonus: {emp3.GetBonus()}");
        }
    }

    // Base class
    public abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract double GetBonus();
    }

    // Subclasses
    public class Engineer : Employee
    {
        public Engineer(string name) : base(name) { }
        public override double GetBonus() => 2000;
    }

    public class Manager : Employee
    {
        public Manager(string name) : base(name) { }
        public override double GetBonus() => 5000;
    }

    public class Sales : Employee
    {
        public Sales(string name) : base(name) { }
        public override double GetBonus() => 3000;
    }
}

