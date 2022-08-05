namespace WindowsForms_Task3
{
    partial class Questionnaire
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.phoneNumberWarningLbl = new System.Windows.Forms.Label();
            this.emailWarningLbl = new System.Windows.Forms.Label();
            this.surnameWarningLbl = new System.Windows.Forms.Label();
            this.nameWarningLbl = new System.Windows.Forms.Label();
            this.phoneNumberMTxtb = new System.Windows.Forms.MaskedTextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.dateOfBirthLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.usersListBx = new System.Windows.Forms.ListBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.filenameLbl = new System.Windows.Forms.Label();
            this.warningLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2DateTimePicker2);
            this.panel1.Controls.Add(this.phoneNumberWarningLbl);
            this.panel1.Controls.Add(this.emailWarningLbl);
            this.panel1.Controls.Add(this.surnameWarningLbl);
            this.panel1.Controls.Add(this.nameWarningLbl);
            this.panel1.Controls.Add(this.phoneNumberMTxtb);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.emailTxtb);
            this.panel1.Controls.Add(this.surnameTxtb);
            this.panel1.Controls.Add(this.nameTxtb);
            this.panel1.Controls.Add(this.dateOfBirthLbl);
            this.panel1.Controls.Add(this.phoneLbl);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.surnameLbl);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(227)))));
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 426);
            this.panel1.TabIndex = 0;
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.Black;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(207, 251);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(228, 31);
            this.guna2DateTimePicker2.TabIndex = 21;
            this.guna2DateTimePicker2.Value = new System.DateTime(2022, 8, 4, 16, 33, 25, 559);
            // 
            // phoneNumberWarningLbl
            // 
            this.phoneNumberWarningLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberWarningLbl.ForeColor = System.Drawing.Color.Red;
            this.phoneNumberWarningLbl.Location = new System.Drawing.Point(208, 225);
            this.phoneNumberWarningLbl.Name = "phoneNumberWarningLbl";
            this.phoneNumberWarningLbl.Size = new System.Drawing.Size(231, 23);
            this.phoneNumberWarningLbl.TabIndex = 19;
            // 
            // emailWarningLbl
            // 
            this.emailWarningLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailWarningLbl.ForeColor = System.Drawing.Color.Red;
            this.emailWarningLbl.Location = new System.Drawing.Point(208, 173);
            this.emailWarningLbl.Name = "emailWarningLbl";
            this.emailWarningLbl.Size = new System.Drawing.Size(231, 23);
            this.emailWarningLbl.TabIndex = 18;
            // 
            // surnameWarningLbl
            // 
            this.surnameWarningLbl.BackColor = System.Drawing.Color.Transparent;
            this.surnameWarningLbl.ForeColor = System.Drawing.Color.Red;
            this.surnameWarningLbl.Location = new System.Drawing.Point(207, 113);
            this.surnameWarningLbl.Name = "surnameWarningLbl";
            this.surnameWarningLbl.Size = new System.Drawing.Size(231, 23);
            this.surnameWarningLbl.TabIndex = 17;
            // 
            // nameWarningLbl
            // 
            this.nameWarningLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameWarningLbl.ForeColor = System.Drawing.Color.Red;
            this.nameWarningLbl.Location = new System.Drawing.Point(207, 52);
            this.nameWarningLbl.Name = "nameWarningLbl";
            this.nameWarningLbl.Size = new System.Drawing.Size(231, 23);
            this.nameWarningLbl.TabIndex = 16;
            // 
            // phoneNumberMTxtb
            // 
            this.phoneNumberMTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberMTxtb.Location = new System.Drawing.Point(207, 187);
            this.phoneNumberMTxtb.Mask = "(999) 000-0000";
            this.phoneNumberMTxtb.Name = "phoneNumberMTxtb";
            this.phoneNumberMTxtb.Size = new System.Drawing.Size(228, 38);
            this.phoneNumberMTxtb.TabIndex = 15;
            // 
            // updateBtn
            // 
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(207, 313);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(108, 41);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(327, 313);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(108, 41);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // emailTxtb
            // 
            this.emailTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtb.Location = new System.Drawing.Point(207, 138);
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(228, 31);
            this.emailTxtb.TabIndex = 11;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTxtb.Location = new System.Drawing.Point(207, 79);
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(228, 31);
            this.surnameTxtb.TabIndex = 10;
            // 
            // nameTxtb
            // 
            this.nameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtb.Location = new System.Drawing.Point(207, 21);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(228, 31);
            this.nameTxtb.TabIndex = 9;
            this.nameTxtb.TextChanged += new System.EventHandler(this.nameTxtb_TextChanged);
            // 
            // dateOfBirthLbl
            // 
            this.dateOfBirthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLbl.Location = new System.Drawing.Point(14, 258);
            this.dateOfBirthLbl.Name = "dateOfBirthLbl";
            this.dateOfBirthLbl.Size = new System.Drawing.Size(163, 23);
            this.dateOfBirthLbl.TabIndex = 8;
            this.dateOfBirthLbl.Text = "Date Of Birth";
            // 
            // phoneLbl
            // 
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(14, 202);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(199, 23);
            this.phoneLbl.TabIndex = 6;
            this.phoneLbl.Text = "Phone Number";
            // 
            // emailLbl
            // 
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(14, 144);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(199, 23);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email";
            // 
            // surnameLbl
            // 
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.Location = new System.Drawing.Point(14, 87);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(199, 23);
            this.surnameLbl.TabIndex = 4;
            this.surnameLbl.Text = "Surname";
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(14, 29);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(199, 23);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name";
            // 
            // usersListBx
            // 
            this.usersListBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.usersListBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersListBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersListBx.FormattingEnabled = true;
            this.usersListBx.ItemHeight = 20;
            this.usersListBx.Location = new System.Drawing.Point(534, 12);
            this.usersListBx.Name = "usersListBx";
            this.usersListBx.Size = new System.Drawing.Size(329, 300);
            this.usersListBx.TabIndex = 1;
            this.usersListBx.SelectedValueChanged += new System.EventHandler(this.usersListBx_SelectedValueChanged);
            // 
            // loadBtn
            // 
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.Black;
            this.loadBtn.Location = new System.Drawing.Point(534, 373);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(154, 41);
            this.loadBtn.TabIndex = 22;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(709, 373);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(154, 41);
            this.SaveBtn.TabIndex = 24;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // filenameLbl
            // 
            this.filenameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(227)))));
            this.filenameLbl.Location = new System.Drawing.Point(529, 326);
            this.filenameLbl.Name = "filenameLbl";
            this.filenameLbl.Size = new System.Drawing.Size(308, 31);
            this.filenameLbl.TabIndex = 25;
            // 
            // warningLbl
            // 
            this.warningLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warningLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLbl.ForeColor = System.Drawing.Color.Red;
            this.warningLbl.Location = new System.Drawing.Point(534, 418);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(329, 23);
            this.warningLbl.TabIndex = 26;
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(110)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.warningLbl);
            this.Controls.Add(this.filenameLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.usersListBx);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Questionnaire";
            this.Text = "Questionnaire";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox usersListBx;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label dateOfBirthLbl;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.MaskedTextBox phoneNumberMTxtb;
        private System.Windows.Forms.Label nameWarningLbl;
        private System.Windows.Forms.Label phoneNumberWarningLbl;
        private System.Windows.Forms.Label emailWarningLbl;
        private System.Windows.Forms.Label surnameWarningLbl;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label filenameLbl;
        private System.Windows.Forms.Label warningLbl;
    }
}

