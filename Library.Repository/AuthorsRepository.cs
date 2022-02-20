using DatabaseHelper;
using Library.DTO;

namespace Library.Repository
{
  public class AuthorsRepository : BaseRepository<Author>
  {
    public AuthorsRepository(Database database) : base(database)
    {

    }

  }
}
