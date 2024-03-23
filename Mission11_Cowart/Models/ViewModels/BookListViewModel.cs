using Mission11_Cowart.Models.ViewModels;

namespace Mission11_Cowart.Models.ViewModels
{
    public class BookListViewModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
