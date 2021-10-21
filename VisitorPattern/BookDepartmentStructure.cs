

namespace VisitorPattern
{
    public class BookDepartmentStructure : BookDepartmentAbstract
    {
        private int numberOfBooks;
        private double avarageDaysPerBookTaken;

        public BookDepartmentStructure(string name, int numberOfBooks,
            double avarageDays)
        {
            this.numberOfBooks = numberOfBooks;
            this.avarageDaysPerBookTaken = avarageDays;
        }

        public int NumberOfBooks
        {
            get { return numberOfBooks; }
            set { numberOfBooks = value; }
        }
        public double AvarageDaysPerBookTaken
        {
            get { return avarageDaysPerBookTaken; }
            set { avarageDaysPerBookTaken = value; }
        }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
