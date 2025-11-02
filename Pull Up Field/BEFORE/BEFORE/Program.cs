using System;

class Soldier
{
    private int health;

    public Soldier(int health)
    {
        this.health = health;
    }

    public void Attack()
    {
        Console.WriteLine("Soldier attacks!");
    }
}

class Tank
{
    private int health;

    public Tank(int health)
    {
        this.health = health;
    }

    public void Fire()
    {
        Console.WriteLine("Tank fires!");
    }
}

class Program
{
    static void Main()
    {
        Soldier soldier = new Soldier(100);
        Tank tank = new Tank(300);

        soldier.Attack();
        tank.Fire();
    }
}


