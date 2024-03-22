using Microsoft.EntityFrameworkCore;

namespace Lilian_Mission_Eleven.Models
{
	public class BookContext : DbContext
	{
		public BookContext(DbContextOptions<BookContext> options) : base(options) { }

		public DbSet<Book> Books { get; set; }
	}
}
