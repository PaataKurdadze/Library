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
using Library.APP.Lists;

namespace Library.APP
{
	public partial class LibraryMain : Form
	{
		public LibraryMain()
		{
			InitializeComponent();
		}

		private void listToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CategoryList listForm = new CategoryList();
			listForm.MdiParent = this;
			listForm.Show();
		}

		private void listToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			BookList listForm = new BookList();
			listForm.MdiParent = this;
			listForm.Show();
		}

		private void btnToolStripAdd_Click(object sender, EventArgs e)
		{
			if (this.ActiveMdiChild != null)
				using (AuthorInsert authorInsert = new AuthorInsert())
				{
					authorInsert.Show();
					authorInsert.MdiParent = this;
				}


		}

		private void addToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (this.ActiveMdiChild != null)
				(this.ActiveMdiChild as IListForm).InsertData();

		}

		private void listToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ShowChildForm<AuthorList>();
		}

		private void ShowChildForm<T>() where T : Form, IListForm, new()
		{
			T listForm = new T();
			listForm.MdiParent = this;
			listForm.LoadData();
			listForm.Show();
		}

		private void LibraryMain_Load(object sender, EventArgs e)
		{
			IsMdiContainer = true;
		}
	}
}
