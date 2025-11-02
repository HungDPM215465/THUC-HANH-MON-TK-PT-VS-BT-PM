using System;

class Employee
{
    private int type;

    // Constructor private để chỉ có thể gọi từ bên trong lớp
    private Employee(int type)
    {
        this.type = type;
    }

    // Factory method tạo Employee
    public static Employee Create(int type)
    {
        Console.WriteLine("Preparing to create an Employee...");

        Employee employee = new Employee(type);

        // Có thể thêm xử lý phức tạp ở đây
        // Ví dụ: load dữ liệu, kiểm tra điều kiện, log, etc.
        Console.WriteLine("Employee created successfully.");

        return employee;
    }
}

class Program
{
    static void Main()
    {
        Employee e = Employee.Create(1);
    }
}
