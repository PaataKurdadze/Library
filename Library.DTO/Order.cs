using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
	public class Order
	{
		public int OrderID { get; set; }
		public int MemberID { get; set; }
		public int BookID { get; set; }
		public int EmployeeID { get; set; }
		public DateTime TakeawayDate { get; set; }
		public DateTime ReturnDate { get; set; }
		public DateTime ActualReturnDate { get; set; }
		public DateTime CreateDate { get; set; }
	}
}
