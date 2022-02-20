using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.DTO;

namespace Library.APP.Details
{
	public partial class AuthorDetails : Form
	{
		public Author Record { get; private set; }

		public AuthorDetails(Author record = null)
		{
			InitializeComponent();
			Record = record;
		}
    }
}
