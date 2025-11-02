using System;

namespace Problem_IntroduceLocalExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new SimpleDate(new DateTime(2025, 10, 15));

            // Logic tính toán nằm ở client
            var nextWeek = date.GetValue().AddDays(7);
            var prevMonth = date.GetValue().AddMonths(-1);

            Console.WriteLine("Current: " + date.GetValue().ToShortDateString());
            Console.WriteLine("Next Week: " + nextWeek.ToShortDateString());
            Console.WriteLine("Previous Month: " + prevMonth.ToShortDateString());
        }
    }

    // Lớp "ngoại lai" mà chúng ta không thể sửa đổi
    class SimpleDate
    {
        private DateTime _value;
        public SimpleDate(DateTime value) { _value = value; }
        public DateTime GetValue() { return _value; }
    }
}