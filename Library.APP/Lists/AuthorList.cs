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
using Library.Repository;
using Library.APP.Details;

namespace Library.APP.Lists
{
	public partial class AuthorList : Form, IListForm
	{
		private UnitOfWork _unitOfWork;

		public AuthorList()
		{
			InitializeComponent();
			_unitOfWork = new UnitOfWork();
			gRAuthorList.AutoGenerateColumns = false;
			LoadData();
		}

		public void LoadData()
		{
			gRAuthorList.DataSource = _unitOfWork.AuthorsRepository.Load(true).ToList();
		}

		public void DeleteData()
		{
			if (MessageBox.Show("", "",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				int id = 0;//grididan vkitxulobt monishnuli chanaweris id-s
				_unitOfWork.AuthorsRepository.Delete(id);
			}
		}

		public void InsertData()
		{
			var detailsForm = new AuthorDetails();
			if (detailsForm.ShowDialog() == DialogResult.OK)
			{
				_unitOfWork.AuthorsRepository.Insert(detailsForm.Record);
				//gridis refreshi
			}
		}

		public void UpdateData()
		{
			int id = 0;//grididan vkitxulobt monishnuli chanaweris id-s
			var record = _unitOfWork.AuthorsRepository.GetByID(id);
			var detailsForm = new AuthorDetails(record);
			if (detailsForm.ShowDialog() == DialogResult.OK)
			{
				_unitOfWork.AuthorsRepository.Update(detailsForm.Record);
				//gridis refreshi
			}
		}
	}
}
