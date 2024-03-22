namespace Lilian_Mission_Eleven.Models
{
	public interface IBookRepository
	{
		public IQueryable<Book> Books { get; }
	}
}
