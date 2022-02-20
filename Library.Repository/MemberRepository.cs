using DatabaseHelper;
using Library.DTO;

namespace Library.Repository
{
  public class MemberRepository : BaseRepository<Member>
  {
    internal MemberRepository(Database database) : base(database)
    {

    }
  }
}

















