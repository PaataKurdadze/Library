using DatabaseHelper;
using Library.DTO;
using Library.Repository;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library.APP.Details
{
    public partial class AuthorInsert : Form
    {
        public AuthorInsert()
        {
            InitializeComponent();
        }

        public void AddEAuthor()
        {
            Database db = new Database(true);
            Author author = new Author()
            {
                FirstName = txtbox_FirstName.Text,
                MiddleName = txtbox_MiddleName.Text,
                LastName = txtbox_LastName.Text
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEAuthor();

            txtbox_FirstName.Clear();
            txtbox_MiddleName.Clear();
            txtbox_LastName.Clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
