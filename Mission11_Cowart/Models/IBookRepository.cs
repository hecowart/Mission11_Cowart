namespace Mission11_Cowart.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
