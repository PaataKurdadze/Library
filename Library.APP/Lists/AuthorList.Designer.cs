
namespace Library.APP.Lists
{
	partial class AuthorList
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gRAuthorList = new System.Windows.Forms.DataGridView();
			this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
			this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
			this.dSsearchAuthor = new System.DirectoryServices.DirectorySearcher();
			this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.gRAuthorList)).BeginInit();
			this.SuspendLayout();
			// 
			// gRAuthorList
			// 
			this.gRAuthorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gRAuthorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorID,
            this.Firstname,
            this.LastName,
            this.MiddleName});
			this.gRAuthorList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gRAuthorList.Location = new System.Drawing.Point(0, 0);
			this.gRAuthorList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gRAuthorList.Name = "gRAuthorList";
			this.gRAuthorList.RowHeadersWidth = 51;
			this.gRAuthorList.RowTemplate.Height = 24;
			this.gRAuthorList.Size = new System.Drawing.Size(800, 450);
			this.gRAuthorList.TabIndex = 3;
			// 
			// directorySearcher1
			// 
			this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
			this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
			this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
			// 
			// directorySearcher2
			// 
			this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
			this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
			this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
			// 
			// dSsearchAuthor
			// 
			this.dSsearchAuthor.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
			this.dSsearchAuthor.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
			this.dSsearchAuthor.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
			// 
			// AuthorID
			// 
			this.AuthorID.DataPropertyName = "AuthorID";
			this.AuthorID.Frozen = true;
			this.AuthorID.HeaderText = "AuthorID";
			this.AuthorID.MinimumWidth = 6;
			this.AuthorID.Name = "AuthorID";
			this.AuthorID.ReadOnly = true;
			this.AuthorID.Width = 125;
			// 
			// Firstname
			// 
			this.Firstname.DataPropertyName = "Firstname";
			this.Firstname.Frozen = true;
			this.Firstname.HeaderText = "Firstname";
			this.Firstname.MinimumWidth = 6;
			this.Firstname.Name = "Firstname";
			this.Firstname.ReadOnly = true;
			this.Firstname.Width = 125;
			// 
			// LastName
			// 
			this.LastName.DataPropertyName = "LastName";
			this.LastName.Frozen = true;
			this.LastName.HeaderText = "LastName";
			this.LastName.MinimumWidth = 6;
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			this.LastName.Width = 125;
			// 
			// MiddleName
			// 
			this.MiddleName.DataPropertyName = "MiddleName";
			this.MiddleName.Frozen = true;
			this.MiddleName.HeaderText = "MiddleName";
			this.MiddleName.MinimumWidth = 6;
			this.MiddleName.Name = "MiddleName";
			this.MiddleName.ReadOnly = true;
			this.MiddleName.Width = 125;
			// 
			// AuthorList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gRAuthorList);
			this.Name = "AuthorList";
			this.Text = "Authors";
			((System.ComponentModel.ISupportInitialize)(this.gRAuthorList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.DataGridView gRAuthorList;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.DirectoryServices.DirectorySearcher dSsearchAuthor;
		private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
	}
}