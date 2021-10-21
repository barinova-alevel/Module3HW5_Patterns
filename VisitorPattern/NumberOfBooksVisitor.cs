using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class NumberOfBooksVisitor : IVisitor
    {
        public void Visit(BookDepartmentAbstract book)
        {
            BookDepartmentStructure department = book as BookDepartmentStructure;
            department.NumberOfBooks *= 2;
            Console.WriteLine("For {0} department new number of books is {1}",
                department.GetType().Name,
                department.NumberOfBooks);
        }
    }
}
