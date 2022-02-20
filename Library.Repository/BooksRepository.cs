using DatabaseHelper;
using Library.DTO;

namespace Library.Repository
{
  public class BooksRepository : BaseRepository<Book>
  {
    internal BooksRepository(Database database) : base(database)
    {

    }
  }
}

















