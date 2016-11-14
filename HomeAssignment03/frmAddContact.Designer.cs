namespace HomeAssignment03
{
	partial class frmAddContact
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
			if(disposing && (components != null))
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
			this.lblWarning = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grpInformation = new System.Windows.Forms.GroupBox();
			this.txtPhoneType = new System.Windows.Forms.ComboBox();
			this.txtAddressType = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPhoneNr = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grpInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Location = new System.Drawing.Point(129, 0);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(0, 13);
			this.lblWarning.TabIndex = 9;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(6, 22);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(224, 228);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 34);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(85, 19);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(239, 20);
			this.txtName.TabIndex = 0;
			this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(118, 228);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 34);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancel_KeyDown);
			// 
			// grpInformation
			// 
			this.grpInformation.Controls.Add(this.btnCancel);
			this.grpInformation.Controls.Add(this.txtPhoneType);
			this.grpInformation.Controls.Add(this.txtAddressType);
			this.grpInformation.Controls.Add(this.label6);
			this.grpInformation.Controls.Add(this.btnSave);
			this.grpInformation.Controls.Add(this.txtPhoneNr);
			this.grpInformation.Controls.Add(this.label7);
			this.grpInformation.Controls.Add(this.label4);
			this.grpInformation.Controls.Add(this.txtCountry);
			this.grpInformation.Controls.Add(this.label5);
			this.grpInformation.Controls.Add(this.txtCity);
			this.grpInformation.Controls.Add(this.label2);
			this.grpInformation.Controls.Add(this.txtZipCode);
			this.grpInformation.Controls.Add(this.label3);
			this.grpInformation.Controls.Add(this.txtAddress);
			this.grpInformation.Controls.Add(this.label1);
			this.grpInformation.Controls.Add(this.txtName);
			this.grpInformation.Controls.Add(this.lblName);
			this.grpInformation.Location = new System.Drawing.Point(12, 12);
			this.grpInformation.Name = "grpInformation";
			this.grpInformation.Size = new System.Drawing.Size(347, 272);
			this.grpInformation.TabIndex = 8;
			this.grpInformation.TabStop = false;
			this.grpInformation.Text = "Information";
			// 
			// txtPhoneType
			// 
			this.txtPhoneType.FormattingEnabled = true;
			this.txtPhoneType.Location = new System.Drawing.Point(85, 201);
			this.txtPhoneType.Name = "txtPhoneType";
			this.txtPhoneType.Size = new System.Drawing.Size(239, 21);
			this.txtPhoneType.TabIndex = 7;
			// 
			// txtAddressType
			// 
			this.txtAddressType.FormattingEnabled = true;
			this.txtAddressType.Location = new System.Drawing.Point(85, 148);
			this.txtAddressType.Name = "txtAddressType";
			this.txtAddressType.Size = new System.Drawing.Size(239, 21);
			this.txtAddressType.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 204);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Phone Type:";
			// 
			// txtPhoneNr
			// 
			this.txtPhoneNr.Location = new System.Drawing.Point(85, 175);
			this.txtPhoneNr.Name = "txtPhoneNr";
			this.txtPhoneNr.Size = new System.Drawing.Size(239, 20);
			this.txtPhoneNr.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Phone Number:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Address Type:";
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(85, 123);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(239, 20);
			this.txtCountry.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Country:";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(85, 97);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(239, 20);
			this.txtCity.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "City:";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(85, 71);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(239, 20);
			this.txtZipCode.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Zip Code:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(85, 45);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(239, 20);
			this.txtAddress.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Address:";
			// 
			// frmAddContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 296);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.grpInformation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmAddContact";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New Contact";
			this.grpInformation.ResumeLayout(false);
			this.grpInformation.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox grpInformation;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPhoneNr;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox txtPhoneType;
		private System.Windows.Forms.ComboBox txtAddressType;
	}
}