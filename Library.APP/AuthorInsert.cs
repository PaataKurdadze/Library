using DatabaseHelper;
using Library.DTO;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.APP
{
  public partial class AuthorInsert : Form
  {
    public AuthorInsert()
    {
      InitializeComponent();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      InsertData();

      txtFirstName.Clear();
      txtMiddleName.Clear();
      txtLastName.Clear();
    }

    private void InsertData()
    {
      Author author = new Author();
      author.FirstName = txtFirstName.Text;
      author.MiddleName = txtMiddleName.Text;
      author.LastName = txtLastName.Text;

      //Database db = new Database(true);
      //AuthorsRepository authorRepository = new AuthorsRepository(db);
      //authorRepository.Insert(author);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

        private void AuthorInsert_Load(object sender, EventArgs e)
        {

        }
  }
}
