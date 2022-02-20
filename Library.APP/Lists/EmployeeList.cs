using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.APP.Interfaces;

namespace Library.APP.Lists
{
	public partial class EmployeeList : Form
	{
		public EmployeeList()
		{
			InitializeComponent();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}

		public void Insert()
		{
			MessageBox.Show("Insert employee");
		}

		public void LoadData()
		{
			throw new NotImplementedException();
		}
	}
}
