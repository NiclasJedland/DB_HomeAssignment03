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
			this.btnChangeName = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.btnAddContact = new System.Windows.Forms.Button();
			this.grpPeople = new System.Windows.Forms.GroupBox();
			this.btnRemoveContact = new System.Windows.Forms.Button();
			this.lstPeople = new System.Windows.Forms.ListBox();
			this.lblWarning = new System.Windows.Forms.Label();
			this.gbSearch = new System.Windows.Forms.GroupBox();
			this.grpPhone = new System.Windows.Forms.GroupBox();
			this.btnAddPhone = new System.Windows.Forms.Button();
			this.btnRemovePhone = new System.Windows.Forms.Button();
			this.dgPhone = new System.Windows.Forms.DataGridView();
			this.PhoneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContactPhoneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grpAddress = new System.Windows.Forms.GroupBox();
			this.dgAddress = new System.Windows.Forms.DataGridView();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ZipeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AddressID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ContactAddressID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAddAddress = new System.Windows.Forms.Button();
			this.btnRemoveAddress = new System.Windows.Forms.Button();
			this.grpAddPhone = new System.Windows.Forms.GroupBox();
			this.btnAddPhoneCancel = new System.Windows.Forms.Button();
			this.btnAddPhoneSave = new System.Windows.Forms.Button();
			this.txtPhoneType = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.grpAddAddress = new System.Windows.Forms.GroupBox();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAddAddressCancel = new System.Windows.Forms.Button();
			this.btnAddAddressSave = new System.Windows.Forms.Button();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtAddressType = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.grpName.SuspendLayout();
			this.grpPeople.SuspendLayout();
			this.gbSearch.SuspendLayout();
			this.grpPhone.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPhone)).BeginInit();
			this.grpAddress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgAddress)).BeginInit();
			this.grpAddPhone.SuspendLayout();
			this.grpAddAddress.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(5, 21);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(521, 20);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.Text = "Search";
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
			this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
			// 
			// grpName
			// 
			this.grpName.Controls.Add(this.btnChangeName);
			this.grpName.Controls.Add(this.txtName);
			this.grpName.Controls.Add(this.lblName);
			this.grpName.Location = new System.Drawing.Point(213, 11);
			this.grpName.Name = "grpName";
			this.grpName.Size = new System.Drawing.Size(329, 50);
			this.grpName.TabIndex = 2;
			this.grpName.TabStop = false;
			this.grpName.Text = "Information";
			// 
			// btnChangeName
			// 
			this.btnChangeName.Location = new System.Drawing.Point(236, 17);
			this.btnChangeName.Name = "btnChangeName";
			this.btnChangeName.Size = new System.Drawing.Size(88, 23);
			this.btnChangeName.TabIndex = 2;
			this.btnChangeName.Text = "Change Name";
			this.btnChangeName.UseVisualStyleBackColor = true;
			this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(50, 19);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(180, 20);
			this.txtName.TabIndex = 1;
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
			// btnAddContact
			// 
			this.btnAddContact.Location = new System.Drawing.Point(102, 245);
			this.btnAddContact.Name = "btnAddContact";
			this.btnAddContact.Size = new System.Drawing.Size(90, 35);
			this.btnAddContact.TabIndex = 1;
			this.btnAddContact.Text = "Add A New Contact";
			this.btnAddContact.UseVisualStyleBackColor = true;
			this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
			// 
			// grpPeople
			// 
			this.grpPeople.Controls.Add(this.btnRemoveContact);
			this.grpPeople.Controls.Add(this.lstPeople);
			this.grpPeople.Controls.Add(this.btnAddContact);
			this.grpPeople.Location = new System.Drawing.Point(8, 11);
			this.grpPeople.Name = "grpPeople";
			this.grpPeople.Size = new System.Drawing.Size(200, 291);
			this.grpPeople.TabIndex = 0;
			this.grpPeople.TabStop = false;
			this.grpPeople.Text = "People";
			// 
			// btnRemoveContact
			// 
			this.btnRemoveContact.Location = new System.Drawing.Point(6, 245);
			this.btnRemoveContact.Name = "btnRemoveContact";
			this.btnRemoveContact.Size = new System.Drawing.Size(90, 35);
			this.btnRemoveContact.TabIndex = 2;
			this.btnRemoveContact.Text = "Remove Contact";
			this.btnRemoveContact.UseVisualStyleBackColor = true;
			this.btnRemoveContact.Click += new System.EventHandler(this.btnRemoveContact_Click);
			// 
			// lstPeople
			// 
			this.lstPeople.FormattingEnabled = true;
			this.lstPeople.Location = new System.Drawing.Point(6, 19);
			this.lstPeople.Name = "lstPeople";
			this.lstPeople.Size = new System.Drawing.Size(188, 212);
			this.lstPeople.TabIndex = 0;
			this.lstPeople.SelectedIndexChanged += new System.EventHandler(this.lstPeople_SelectedIndexChanged);
			this.lstPeople.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPeople_KeyDown);
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
			this.gbSearch.Location = new System.Drawing.Point(14, 529);
			this.gbSearch.Margin = new System.Windows.Forms.Padding(2);
			this.gbSearch.Name = "gbSearch";
			this.gbSearch.Padding = new System.Windows.Forms.Padding(2);
			this.gbSearch.Size = new System.Drawing.Size(531, 55);
			this.gbSearch.TabIndex = 23;
			this.gbSearch.TabStop = false;
			this.gbSearch.Text = "Search";
			// 
			// grpPhone
			// 
			this.grpPhone.Controls.Add(this.btnAddPhone);
			this.grpPhone.Controls.Add(this.btnRemovePhone);
			this.grpPhone.Controls.Add(this.dgPhone);
			this.grpPhone.Location = new System.Drawing.Point(211, 66);
			this.grpPhone.Margin = new System.Windows.Forms.Padding(2);
			this.grpPhone.Name = "grpPhone";
			this.grpPhone.Padding = new System.Windows.Forms.Padding(2);
			this.grpPhone.Size = new System.Drawing.Size(329, 236);
			this.grpPhone.TabIndex = 24;
			this.grpPhone.TabStop = false;
			this.grpPhone.Text = "Phone Numbers";
			// 
			// btnAddPhone
			// 
			this.btnAddPhone.Location = new System.Drawing.Point(223, 190);
			this.btnAddPhone.Name = "btnAddPhone";
			this.btnAddPhone.Size = new System.Drawing.Size(100, 34);
			this.btnAddPhone.TabIndex = 1;
			this.btnAddPhone.Text = "Add New Phone Number";
			this.btnAddPhone.UseVisualStyleBackColor = true;
			this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
			// 
			// btnRemovePhone
			// 
			this.btnRemovePhone.Location = new System.Drawing.Point(117, 191);
			this.btnRemovePhone.Name = "btnRemovePhone";
			this.btnRemovePhone.Size = new System.Drawing.Size(100, 34);
			this.btnRemovePhone.TabIndex = 0;
			this.btnRemovePhone.Text = "Remove Phone Number";
			this.btnRemovePhone.UseVisualStyleBackColor = true;
			this.btnRemovePhone.Click += new System.EventHandler(this.btnRemovePhone_Click);
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
            this.PhoneID,
            this.ContactPhoneID});
			this.dgPhone.Location = new System.Drawing.Point(10, 17);
			this.dgPhone.MultiSelect = false;
			this.dgPhone.Name = "dgPhone";
			this.dgPhone.RowHeadersVisible = false;
			this.dgPhone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPhone.Size = new System.Drawing.Size(314, 168);
			this.dgPhone.TabIndex = 0;
			this.dgPhone.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhone_CellValueChanged);
			// 
			// PhoneType
			// 
			this.PhoneType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.PhoneType.HeaderText = "Type";
			this.PhoneType.Name = "PhoneType";
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
			// ContactPhoneID
			// 
			this.ContactPhoneID.HeaderText = "ContactPhoneID";
			this.ContactPhoneID.Name = "ContactPhoneID";
			this.ContactPhoneID.ReadOnly = true;
			this.ContactPhoneID.Visible = false;
			// 
			// grpAddress
			// 
			this.grpAddress.Controls.Add(this.dgAddress);
			this.grpAddress.Controls.Add(this.btnAddAddress);
			this.grpAddress.Controls.Add(this.btnRemoveAddress);
			this.grpAddress.Location = new System.Drawing.Point(11, 302);
			this.grpAddress.Margin = new System.Windows.Forms.Padding(2);
			this.grpAddress.Name = "grpAddress";
			this.grpAddress.Padding = new System.Windows.Forms.Padding(2);
			this.grpAddress.Size = new System.Drawing.Size(534, 218);
			this.grpAddress.TabIndex = 4;
			this.grpAddress.TabStop = false;
			this.grpAddress.Text = "Address";
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
            this.AddressID,
            this.ContactAddressID});
			this.dgAddress.Location = new System.Drawing.Point(11, 18);
			this.dgAddress.MultiSelect = false;
			this.dgAddress.Name = "dgAddress";
			this.dgAddress.RowHeadersVisible = false;
			this.dgAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAddress.Size = new System.Drawing.Size(515, 152);
			this.dgAddress.TabIndex = 0;
			this.dgAddress.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAddress_CellValueChanged);
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
			// ContactAddressID
			// 
			this.ContactAddressID.HeaderText = "ContactAddressID";
			this.ContactAddressID.Name = "ContactAddressID";
			this.ContactAddressID.ReadOnly = true;
			this.ContactAddressID.Visible = false;
			// 
			// btnAddAddress
			// 
			this.btnAddAddress.Location = new System.Drawing.Point(267, 176);
			this.btnAddAddress.Name = "btnAddAddress";
			this.btnAddAddress.Size = new System.Drawing.Size(100, 34);
			this.btnAddAddress.TabIndex = 2;
			this.btnAddAddress.Text = "Add New Address";
			this.btnAddAddress.UseVisualStyleBackColor = true;
			this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
			// 
			// btnRemoveAddress
			// 
			this.btnRemoveAddress.Location = new System.Drawing.Point(161, 176);
			this.btnRemoveAddress.Name = "btnRemoveAddress";
			this.btnRemoveAddress.Size = new System.Drawing.Size(100, 34);
			this.btnRemoveAddress.TabIndex = 1;
			this.btnRemoveAddress.Text = "Remove Address";
			this.btnRemoveAddress.UseVisualStyleBackColor = true;
			this.btnRemoveAddress.Click += new System.EventHandler(this.btnRemoveAddress_Click);
			// 
			// grpAddPhone
			// 
			this.grpAddPhone.Controls.Add(this.btnAddPhoneCancel);
			this.grpAddPhone.Controls.Add(this.btnAddPhoneSave);
			this.grpAddPhone.Controls.Add(this.txtPhoneType);
			this.grpAddPhone.Controls.Add(this.label2);
			this.grpAddPhone.Controls.Add(this.label1);
			this.grpAddPhone.Controls.Add(this.txtPhoneNumber);
			this.grpAddPhone.Location = new System.Drawing.Point(215, 62);
			this.grpAddPhone.Name = "grpAddPhone";
			this.grpAddPhone.Size = new System.Drawing.Size(327, 130);
			this.grpAddPhone.TabIndex = 3;
			this.grpAddPhone.TabStop = false;
			this.grpAddPhone.Text = "Add New Phonenumber";
			this.grpAddPhone.Visible = false;
			// 
			// btnAddPhoneCancel
			// 
			this.btnAddPhoneCancel.Location = new System.Drawing.Point(153, 88);
			this.btnAddPhoneCancel.Name = "btnAddPhoneCancel";
			this.btnAddPhoneCancel.Size = new System.Drawing.Size(75, 23);
			this.btnAddPhoneCancel.TabIndex = 3;
			this.btnAddPhoneCancel.Text = "Cancel";
			this.btnAddPhoneCancel.UseVisualStyleBackColor = true;
			this.btnAddPhoneCancel.Click += new System.EventHandler(this.btnAddPhoneCancel_Click);
			// 
			// btnAddPhoneSave
			// 
			this.btnAddPhoneSave.Location = new System.Drawing.Point(234, 88);
			this.btnAddPhoneSave.Name = "btnAddPhoneSave";
			this.btnAddPhoneSave.Size = new System.Drawing.Size(75, 23);
			this.btnAddPhoneSave.TabIndex = 2;
			this.btnAddPhoneSave.Text = "Save";
			this.btnAddPhoneSave.UseVisualStyleBackColor = true;
			this.btnAddPhoneSave.Click += new System.EventHandler(this.btnAddPhoneSave_Click);
			// 
			// txtPhoneType
			// 
			this.txtPhoneType.Location = new System.Drawing.Point(89, 47);
			this.txtPhoneType.Name = "txtPhoneType";
			this.txtPhoneType.Size = new System.Drawing.Size(220, 20);
			this.txtPhoneType.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Type:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Number:";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(89, 21);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(220, 20);
			this.txtPhoneNumber.TabIndex = 0;
			// 
			// grpAddAddress
			// 
			this.grpAddAddress.Controls.Add(this.txtCountry);
			this.grpAddAddress.Controls.Add(this.label7);
			this.grpAddAddress.Controls.Add(this.txtCity);
			this.grpAddAddress.Controls.Add(this.label6);
			this.grpAddAddress.Controls.Add(this.txtZipCode);
			this.grpAddAddress.Controls.Add(this.label5);
			this.grpAddAddress.Controls.Add(this.btnAddAddressCancel);
			this.grpAddAddress.Controls.Add(this.btnAddAddressSave);
			this.grpAddAddress.Controls.Add(this.txtAddress);
			this.grpAddAddress.Controls.Add(this.txtAddressType);
			this.grpAddAddress.Controls.Add(this.label4);
			this.grpAddAddress.Controls.Add(this.label3);
			this.grpAddAddress.Location = new System.Drawing.Point(11, 302);
			this.grpAddAddress.Name = "grpAddAddress";
			this.grpAddAddress.Size = new System.Drawing.Size(336, 223);
			this.grpAddAddress.TabIndex = 28;
			this.grpAddAddress.TabStop = false;
			this.grpAddAddress.Text = "Add New Address";
			this.grpAddAddress.Visible = false;
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(94, 97);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(220, 20);
			this.txtCountry.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Country:";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(94, 71);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(220, 20);
			this.txtCity.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "City:";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(94, 45);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(220, 20);
			this.txtZipCode.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Zip Code:";
			// 
			// btnAddAddressCancel
			// 
			this.btnAddAddressCancel.Location = new System.Drawing.Point(158, 176);
			this.btnAddAddressCancel.Name = "btnAddAddressCancel";
			this.btnAddAddressCancel.Size = new System.Drawing.Size(75, 23);
			this.btnAddAddressCancel.TabIndex = 6;
			this.btnAddAddressCancel.Text = "Cancel";
			this.btnAddAddressCancel.UseVisualStyleBackColor = true;
			this.btnAddAddressCancel.Click += new System.EventHandler(this.btnAddAddressCancel_Click);
			// 
			// btnAddAddressSave
			// 
			this.btnAddAddressSave.Location = new System.Drawing.Point(239, 176);
			this.btnAddAddressSave.Name = "btnAddAddressSave";
			this.btnAddAddressSave.Size = new System.Drawing.Size(75, 23);
			this.btnAddAddressSave.TabIndex = 5;
			this.btnAddAddressSave.Text = "Save";
			this.btnAddAddressSave.UseVisualStyleBackColor = true;
			this.btnAddAddressSave.Click += new System.EventHandler(this.btnAddAddressSave_Click);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(94, 19);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(220, 20);
			this.txtAddress.TabIndex = 0;
			// 
			// txtAddressType
			// 
			this.txtAddressType.Location = new System.Drawing.Point(94, 123);
			this.txtAddressType.Name = "txtAddressType";
			this.txtAddressType.Size = new System.Drawing.Size(220, 20);
			this.txtAddressType.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Address:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Type:";
			// 
			// Adressbook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 590);
			this.Controls.Add(this.grpPhone);
			this.Controls.Add(this.grpAddress);
			this.Controls.Add(this.grpAddPhone);
			this.Controls.Add(this.gbSearch);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.grpName);
			this.Controls.Add(this.grpPeople);
			this.Controls.Add(this.grpAddAddress);
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
			((System.ComponentModel.ISupportInitialize)(this.dgPhone)).EndInit();
			this.grpAddress.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgAddress)).EndInit();
			this.grpAddPhone.ResumeLayout(false);
			this.grpAddPhone.PerformLayout();
			this.grpAddAddress.ResumeLayout(false);
			this.grpAddAddress.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.GroupBox grpName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnAddContact;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.GroupBox grpPeople;
		private System.Windows.Forms.ListBox lstPeople;
		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.GroupBox gbSearch;
		private System.Windows.Forms.GroupBox grpPhone;
		private System.Windows.Forms.GroupBox grpAddress;
		private System.Windows.Forms.DataGridView dgPhone;
		private System.Windows.Forms.DataGridView dgAddress;
		private System.Windows.Forms.Button btnRemoveContact;
		private System.Windows.Forms.Button btnRemovePhone;
		private System.Windows.Forms.Button btnRemoveAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneType;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhoneID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContactPhoneID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn ZipeCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn Country;
		private System.Windows.Forms.DataGridViewTextBoxColumn AddressID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ContactAddressID;
		private System.Windows.Forms.Button btnAddPhone;
		private System.Windows.Forms.Button btnAddAddress;
		private System.Windows.Forms.GroupBox grpAddPhone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.TextBox txtPhoneType;
		private System.Windows.Forms.Button btnAddPhoneCancel;
		private System.Windows.Forms.Button btnAddPhoneSave;
		private System.Windows.Forms.GroupBox grpAddAddress;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAddAddressCancel;
		private System.Windows.Forms.Button btnAddAddressSave;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtAddressType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnChangeName;
	}
}

