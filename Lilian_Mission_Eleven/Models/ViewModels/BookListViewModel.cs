namespace Lilian_Mission_Eleven.Models.ViewModels
{
	public class BookListViewModel
	{
		public IQueryable<Book> Books { get; set; }
		public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
	}
}
