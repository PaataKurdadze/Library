using DatabaseHelper;
using Library.DTO;

namespace Library.Repository
{
  public class OrdersRepository : BaseRepository<Order>
  {
    internal OrdersRepository(Database database) : base(database)
    {

    }
  }
}

















