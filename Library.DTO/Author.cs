using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
  public class Author
  {
    public int AuthorID { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }
  }
}
