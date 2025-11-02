using System;

namespace Solution_InlineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nguyễn Văn A", "028", "38123456");
            Console.WriteLine(person.GetTelephoneNumber());
        }
    }

    class Person
    {
        public string Name { get; private set; }
        public string OfficeAreaCode { get; private set; }
        public string OfficeNumber { get; private set; }

        public Person(string name, string areaCode, string number)
        {
            Name = name;
            OfficeAreaCode = areaCode;
            OfficeNumber = number;
        }

        public string GetTelephoneNumber()
        {
            return "(" + OfficeAreaCode + ") " + OfficeNumber;
        }
    }
}