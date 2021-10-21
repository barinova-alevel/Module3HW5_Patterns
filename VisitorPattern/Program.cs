using System;

namespace VisitorPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Books employee = new Books();
            employee.Attach(new History());
            employee.Attach(new SciFi());
            employee.Attach(new LoveStories());
            employee.Accept(new NumberOfBooksVisitor());
            employee.Accept(new DaysTakenVisitor());

            Console.ReadKey();
        }
    }
}
