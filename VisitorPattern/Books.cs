using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Books
    {
        private List<BookDepartmentStructure> books = new List<BookDepartmentStructure>();
        public void Attach(BookDepartmentStructure books)
        {
            this.books.Add(books);
        }
        public void Detach(BookDepartmentStructure books)
        {
            this.books.Remove(books);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (BookDepartmentStructure book in books)
            {
                book.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
