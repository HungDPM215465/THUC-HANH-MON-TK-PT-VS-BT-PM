using System;

class Soldier
{
    private int health;

    public Soldier(int health)
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return health;
    }
}

class Tank
{
    private int health;

    public Tank(int health)
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return health;
    }
}
class Program
{
    static void Main()
    {
        Soldier soldier = new Soldier(100);
        Tank tank = new Tank(300);

        Console.WriteLine("Soldier health: " + soldier.GetHealth());
        Console.WriteLine("Tank health: " + tank.GetHealth());
    }
}
