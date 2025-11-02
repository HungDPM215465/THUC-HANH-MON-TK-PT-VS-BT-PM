using System;

class Employee
{
}

class Manager : Employee
{
    private string name;
    private string id;
    private string grade;

    public Manager(string name, string id, string grade)
    {
        this.name = name;
        this.id = id;
        this.grade = grade;
    }
}

class Engineer : Employee
{
    private string name;
    private string id;
    private string level;

    public Engineer(string name, string id, string level)
    {
        this.name = name;
        this.id = id;
        this.level = level;
    }
}
