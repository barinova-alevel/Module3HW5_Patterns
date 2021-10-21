namespace VisitorPattern
{
    public abstract class BookDepartmentAbstract
    {
        public abstract void Accept(IVisitor visitor);
    }
}
