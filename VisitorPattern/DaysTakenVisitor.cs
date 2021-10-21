namespace VisitorPattern
{
    using System;

    class DaysTakenVisitor : IVisitor
    {
        public void Visit(BookDepartmentAbstract book)
        {
            BookDepartmentStructure department = book as BookDepartmentStructure;
            department.AvarageDaysPerBookTaken += 1.5;
            Console.WriteLine("For {0} department new avarage days per book taken is  {1}",
                department.GetType().Name,
                department.AvarageDaysPerBookTaken);
        }
    }
}