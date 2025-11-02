using System;

namespace ReplaceConditionalWithPolymorphism_AFTER
{
    public abstract class Bird
    {
        protected int numberOfCoconuts;
        protected bool isNailed;
        protected double voltage;

        public abstract double GetSpeed();

        protected double GetBaseSpeed(double voltage = 1) => 10 * voltage;
        protected double GetLoadFactor() => 2.0;
    }

    public class European : Bird
    {
        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
    }

    public class African : Bird
    {
        public African(int coconuts)
        {
            numberOfCoconuts = coconuts;
        }

        public override double GetSpeed()
        {
            return GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts;
        }
    }

    public class NorwegianBlue : Bird
    {
        public NorwegianBlue(bool nailed, double voltage)
        {
            isNailed = nailed;
            this.voltage = voltage;
        }

        public override double GetSpeed()
        {
            return isNailed ? 0 : GetBaseSpeed(voltage);
        }
    }

    class Program
    {
        static void Main()
        {
            Bird b1 = new European();
            Bird b2 = new African(3);
            Bird b3 = new NorwegianBlue(false, 1.5);

            Console.WriteLine("=== AFTER ===");
            Console.WriteLine($"European speed: {b1.GetSpeed()}");
            Console.WriteLine($"African speed: {b2.GetSpeed()}");
            Console.WriteLine($"Norwegian Blue speed: {b3.GetSpeed()}");
        }
    }
}

