using System;

class Unit
{
    protected int health;

    public Unit(int health)
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return health;
    }
}

class Soldier : Unit
{
    public Soldier(int health) : base(health) { }
}

class Tank : Unit
{
    public Tank(int health) : base(health) { }
}

class Program
{
    static void Main()
    {
        Soldier soldier = new Soldier(100);
        Tank tank = new Tank(300);

        Console.WriteLine(soldier.GetHealth());
        Console.WriteLine(tank.GetHealth());
    }
}

