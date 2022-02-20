using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
  public class Book
  {
    public int BookID { get; set; }
    public int CategoryID { get; set; }
    public string Title { get; set; }
    public DateTime PublishingDate { get; set; }
    public string Publisher { get; set; }
    public bool Status { get; set; }
    public decimal Price { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreateDate { get; set; }
    public string Description { get; set; }
  }
}
