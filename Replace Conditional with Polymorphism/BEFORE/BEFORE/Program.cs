using System;

namespace ReplaceConditionalWithPolymorphism_BEFORE
{
    public class Bird
    {
        private string type;
        private int numberOfCoconuts;
        private bool isNailed;
        private double voltage;

        public Bird(string type, int coconuts = 0, bool nailed = false, double voltage = 1)
        {
            this.type = type;
            this.numberOfCoconuts = coconuts;
            this.isNailed = nailed;
            this.voltage = voltage;
        }

        public double GetSpeed()
        {
            switch (type)
            {
                case "EUROPEAN":
                    return GetBaseSpeed();
                case "AFRICAN":
                    return GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts;
                case "NORWEGIAN_BLUE":
                    return isNailed ? 0 : GetBaseSpeed(voltage);
                default:
                    throw new Exception("Invalid bird type");
            }
        }

        private double GetBaseSpeed(double voltage = 1) => 10 * voltage;
        private double GetLoadFactor() => 2.0;
    }

    class Program
    {
        static void Main()
        {
            Bird b1 = new Bird("EUROPEAN");
            Bird b2 = new Bird("AFRICAN", coconuts: 3);
            Bird b3 = new Bird("NORWEGIAN_BLUE", nailed: false, voltage: 1.5);

            Console.WriteLine("=== BEFORE ===");
            Console.WriteLine($"European speed: {b1.GetSpeed()}");
            Console.WriteLine($"African speed: {b2.GetSpeed()}");
            Console.WriteLine($"Norwegian Blue speed: {b3.GetSpeed()}");
        }
    }
}

