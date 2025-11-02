using System;

class Unit
{
    // Không còn GetFuel() ở đây
}

class Soldier : Unit
{
    public void Attack()
    {
        Console.WriteLine("Soldier attacks!");
    }
}

class Tank : Unit
{
    public void Fire()
    {
        Console.WriteLine("Tank fires!");
    }

    public void GetFuel()
    {
        Console.WriteLine("Tank refueling...");
    }
}

class Program
{
    static void Main()
    {
        Soldier soldier = new Soldier();
        Tank tank = new Tank();

        soldier.Attack();
        tank.Fire();
        tank.GetFuel();
    }
}
