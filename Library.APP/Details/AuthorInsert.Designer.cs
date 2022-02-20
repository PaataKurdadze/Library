
namespace Library.APP.Details
{
    partial class AuthorInsert
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
            this.txtbox_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_MiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_FirstName
            // 
            this.txtbox_FirstName.Location = new System.Drawing.Point(134, 9);
            this.txtbox_FirstName.Name = "txtbox_FirstName";
            this.txtbox_FirstName.Size = new System.Drawing.Size(308, 22);
            this.txtbox_FirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // txtbox_LastName
            // 
            this.txtbox_LastName.Location = new System.Drawing.Point(134, 107);
            this.txtbox_LastName.Name = "txtbox_LastName";
            this.txtbox_LastName.Size = new System.Drawing.Size(308, 22);
            this.txtbox_LastName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // txtbox_MiddleName
            // 
            this.txtbox_MiddleName.Location = new System.Drawing.Point(134, 58);
            this.txtbox_MiddleName.Name = "txtbox_MiddleName";
            this.txtbox_MiddleName.Size = new System.Drawing.Size(308, 22);
            this.txtbox_MiddleName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "MiddleName";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(134, 178);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(367, 178);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AuthorInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 231);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_MiddleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_FirstName);
            this.Name = "AuthorInsert";
            this.Text = "AddNewAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_MiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
    }
}