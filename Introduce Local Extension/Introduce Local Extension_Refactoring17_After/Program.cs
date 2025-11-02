using System;

namespace Solution_IntroduceLocalExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalDate = new SimpleDate(new DateTime(2025, 10, 15));
            var date = new DateExtension(originalDate); // "Bao bọc" đối tượng gốc

            var nextWeek = date.NextWeek();
            var prevMonth = date.PreviousMonth();

            Console.WriteLine("Current: " + date.GetValue().ToShortDateString());
            Console.WriteLine("Next Week: " + nextWeek.GetValue().ToShortDateString());
            Console.WriteLine("Previous Month: " + prevMonth.GetValue().ToShortDateString());
        }
    }

    // Lớp "ngoại lai" không đổi
    class SimpleDate
    {
        private DateTime _value;
        public SimpleDate(DateTime value) { _value = value; }
        public DateTime GetValue() { return _value; }
    }

    // Lớp mở rộng cục bộ của chúng ta
    class DateExtension
    {
        private SimpleDate _originalDate;
        public DateExtension(SimpleDate date) { _originalDate = date; }
        public DateTime GetValue() { return _originalDate.GetValue(); }
        public DateExtension NextWeek()
        {
            return new DateExtension(new SimpleDate(GetValue().AddDays(7)));
        }
        public DateExtension PreviousMonth()
        {
            return new DateExtension(new SimpleDate(GetValue().AddMonths(-1)));
        }
    }
}