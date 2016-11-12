namespace HomeAssignment03
{
	partial class Adressbook
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
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.grpName = new System.Windows.Forms.GroupBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAddContact = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.grpPeople = new System.Windows.Forms.GroupBox();
			this.lstPeople = new System.Windows.Forms.ListBox();
			this.lblWarning = new System.Windows.Forms.Label();
			this.gbSearch = new System.Windows.Forms.GroupBox();
			this.grpPhone = new System.Windows.Forms.GroupBox();
			this.grpAddress = new System.Windows.Forms.GroupBox();
			this.dgPhone = new System.Windows.Forms.DataGridView();
			this.dgAddress = new System.Windows.Forms.DataGridView();
			this.PhoneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ZipeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddressID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grpName.SuspendLayout();
			this.grpPeople.SuspendLayout();
			this.gbSearch.SuspendLayout();
			this.grpPhone.SuspendLayout();
			this.grpAddress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPhone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgAddress)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(5, 21);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(188, 20);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// grpName
			// 
			this.grpName.Controls.Add(this.txtName);
			this.grpName.Controls.Add(this.lblName);
			this.grpName.Location = new System.Drawing.Point(213, 11);
			this.grpName.Name = "grpName";
			this.grpName.Size = new System.Drawing.Size(329, 50);
			this.grpName.TabIndex = 5;
			this.grpName.TabStop = false;
			this.grpName.Text = "Information";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(110, 19);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(211, 20);
			this.txtName.TabIndex = 2;
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
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(98, 495);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(100, 34);
			this.btnRemove.TabIndex = 12;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAddContact
			// 
			this.btnAddContact.Location = new System.Drawing.Point(207, 495);
			this.btnAddContact.Name = "btnAddContact";
			this.btnAddContact.Size = new System.Drawing.Size(100, 34);
			this.btnAddContact.TabIndex = 11;
			this.btnAddContact.Text = "Add A New Contact";
			this.btnAddContact.UseVisualStyleBackColor = true;
			this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(314, 495);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(100, 34);
			this.btnSaveChanges.TabIndex = 10;
			this.btnSaveChanges.Text = "Save Changes";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// grpPeople
			// 
			this.grpPeople.Controls.Add(this.lstPeople);
			this.grpPeople.Location = new System.Drawing.Point(8, 11);
			this.grpPeople.Name = "grpPeople";
			this.grpPeople.Size = new System.Drawing.Size(200, 240);
			this.grpPeople.TabIndex = 4;
			this.grpPeople.TabStop = false;
			this.grpPeople.Text = "People";
			// 
			// lstPeople
			// 
			this.lstPeople.FormattingEnabled = true;
			this.lstPeople.Location = new System.Drawing.Point(6, 19);
			this.lstPeople.Name = "lstPeople";
			this.lstPeople.Size = new System.Drawing.Size(188, 212);
			this.lstPeople.TabIndex = 0;
			this.lstPeople.SelectedIndexChanged += new System.EventHandler(this.lstPeople_SelectedIndexChanged);
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.Location = new System.Drawing.Point(325, 5);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(0, 13);
			this.lblWarning.TabIndex = 22;
			// 
			// gbSearch
			// 
			this.gbSearch.Controls.Add(this.txtSearch);
			this.gbSearch.Location = new System.Drawing.Point(9, 247);
			this.gbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbSearch.Name = "gbSearch";
			this.gbSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbSearch.Size = new System.Drawing.Size(200, 55);
			this.gbSearch.TabIndex = 23;
			this.gbSearch.TabStop = false;
			this.gbSearch.Text = "Search";
			// 
			// grpPhone
			// 
			this.grpPhone.Controls.Add(this.dgPhone);
			this.grpPhone.Location = new System.Drawing.Point(213, 66);
			this.grpPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.grpPhone.Name = "grpPhone";
			this.grpPhone.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.grpPhone.Size = new System.Drawing.Size(329, 236);
			this.grpPhone.TabIndex = 24;
			this.grpPhone.TabStop = false;
			this.grpPhone.Text = "Phone Numbers";
			// 
			// grpAddress
			// 
			this.grpAddress.Controls.Add(this.dgAddress);
			this.grpAddress.Location = new System.Drawing.Point(8, 306);
			this.grpAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.grpAddress.Name = "grpAddress";
			this.grpAddress.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.grpAddress.Size = new System.Drawing.Size(534, 175);
			this.grpAddress.TabIndex = 25;
			this.grpAddress.TabStop = false;
			this.grpAddress.Text = "Address";
			// 
			// dgPhone
			// 
			this.dgPhone.AllowUserToAddRows = false;
			this.dgPhone.AllowUserToResizeRows = false;
			this.dgPhone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPhone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneType,
            this.PhoneNumber,
            this.PhoneID});
			this.dgPhone.Location = new System.Drawing.Point(10, 17);
			this.dgPhone.Name = "dgPhone";
			this.dgPhone.RowHeadersVisible = false;
			this.dgPhone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPhone.Size = new System.Drawing.Size(314, 214);
			this.dgPhone.TabIndex = 0;
			this.dgPhone.Visible = false;
			// 
			// dgAddress
			// 
			this.dgAddress.AllowUserToAddRows = false;
			this.dgAddress.AllowUserToResizeRows = false;
			this.dgAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Address,
            this.ZipeCode,
            this.City,
            this.Country,
            this.AddressID});
			this.dgAddress.Location = new System.Drawing.Point(11, 18);
			this.dgAddress.Name = "dgAddress";
			this.dgAddress.RowHeadersVisible = false;
			this.dgAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAddress.Size = new System.Drawing.Size(515, 152);
			this.dgAddress.TabIndex = 1;
			this.dgAddress.Visible = false;
			// 
			// PhoneType
			// 
			this.PhoneType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.PhoneType.HeaderText = "Type";
			this.PhoneType.Name = "PhoneType";
			this.PhoneType.ReadOnly = true;
			this.PhoneType.Width = 56;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PhoneNumber.HeaderText = "Phone Number";
			this.PhoneNumber.Name = "PhoneNumber";
			// 
			// PhoneID
			// 
			this.PhoneID.HeaderText = "PhoneID";
			this.PhoneID.Name = "PhoneID";
			this.PhoneID.ReadOnly = true;
			this.PhoneID.Visible = false;
			// 
			// Type
			// 
			this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Type.HeaderText = "Type";
			this.Type.Name = "Type";
			this.Type.Width = 56;
			// 
			// Address
			// 
			this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Address.HeaderText = "Address";
			this.Address.Name = "Address";
			// 
			// ZipeCode
			// 
			this.ZipeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ZipeCode.HeaderText = "Zip Code";
			this.ZipeCode.Name = "ZipeCode";
			this.ZipeCode.Width = 75;
			// 
			// City
			// 
			this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.City.HeaderText = "City";
			this.City.Name = "City";
			this.City.Width = 49;
			// 
			// Country
			// 
			this.Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Country.HeaderText = "Country";
			this.Country.Name = "Country";
			this.Country.Width = 68;
			// 
			// AddressID
			// 
			this.AddressID.HeaderText = "AddressID";
			this.AddressID.Name = "AddressID";
			this.AddressID.ReadOnly = true;
			this.AddressID.Visible = false;
			// 
			// Adressbook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 542);
			this.Controls.Add(this.btnSaveChanges);
			this.Controls.Add(this.grpAddress);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.grpPhone);
			this.Controls.Add(this.btnAddContact);
			this.Controls.Add(this.gbSearch);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.grpName);
			this.Controls.Add(this.grpPeople);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Adressbook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contacts";
			this.Load += new System.EventHandler(this.Adressbook_Load);
			this.grpName.ResumeLayout(false);
			this.grpName.PerformLayout();
			this.grpPeople.ResumeLayout(false);
			this.gbSearch.ResumeLayout(false);
			this.gbSearch.PerformLayout();
			this.grpPhone.ResumeLayout(false);
			this.grpAddress.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPhone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgAddress)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.GroupBox grpName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAddContact;
		private System.Windows.Forms.Button btnSaveChanges;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.GroupBox grpPeople;
		private System.Windows.Forms.ListBox lstPeople;
		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.GroupBox gbSearch;
		private System.Windows.Forms.GroupBox grpPhone;
		private System.Windows.Forms.GroupBox grpAddress;
		private System.Windows.Forms.DataGridView dgPhone;
		private System.Windows.Forms.DataGridView dgAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneType;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn ZipeCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn Country;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressID;
	}
}

