using Library.APP.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.APP.Lists
{
	public partial class CategoryList : Form
	{
		public CategoryList()
		{
			InitializeComponent();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}

		public void Insert()
		{
			MessageBox.Show("Insert category");
		}

		public void LoadData()
		{
			throw new NotImplementedException();
		}
	}
}
