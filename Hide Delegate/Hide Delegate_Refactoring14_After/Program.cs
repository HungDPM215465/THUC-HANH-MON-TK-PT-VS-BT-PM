using System;

namespace Solution_HideDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager("Bình");
            var department = new Department(manager);
            var person = new Person("Nguyễn Văn A", department);

            Manager personManager = person.GetManager();
            Console.WriteLine(person.Name + "'s manager is " + personManager.Name);
        }
    }

    class Manager { public string Name { get; set; } public Manager(string name) { Name = name; } }
    class Department { private Manager _manager; public Department(Manager manager) { _manager = manager; } public Manager GetManager() { return _manager; } }
    class Person { public string Name { get; private set; } private Department _department; public Person(string name, Department department) { Name = name; _department = department; } public Manager GetManager() { return _department.GetManager(); } }
}