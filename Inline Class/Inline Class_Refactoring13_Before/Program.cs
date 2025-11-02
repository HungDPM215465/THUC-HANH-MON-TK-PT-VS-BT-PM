using System;

namespace Problem_InlineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var telephone = new TelephoneNumber("028", "38123456");
            var person = new Person("Nguyễn Văn A", telephone);
            Console.WriteLine(person.GetOfficeTelephone().GetFullNumber());
        }
    }

    class TelephoneNumber
    {
        public string AreaCode { get; private set; }
        public string Number { get; private set; }

        public TelephoneNumber(string areaCode, string number)
        {
            AreaCode = areaCode;
            Number = number;
        }

        public string GetFullNumber()
        {
            return "(" + AreaCode + ") " + Number;
        }
    }

    class Person
    {
        public string Name { get; private set; }
        private TelephoneNumber _officeTelephone;

        public Person(string name, TelephoneNumber telephone)
        {
            Name = name;
            _officeTelephone = telephone;
        }

        public TelephoneNumber GetOfficeTelephone()
        {
            return _officeTelephone;
        }
    }
}