using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
	public class Employee
	{
		public int EmployeeID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int PositionID { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime HireDate { get; set; }
		public string HomeAddress { get; set; }
		public string PhoneNumber { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime CreateDate { get; set; }
	}
}

