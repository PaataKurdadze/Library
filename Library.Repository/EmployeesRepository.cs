using DatabaseHelper;
using Library.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
  public class EmployeesRepository : BaseRepository<Employee>
  {
    internal EmployeesRepository(Database database) : base(database)
    {

    }
  }
}