using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HomeAssignment03
{
	public partial class frmAddContact : Form
	{
		ContactContext db = new ContactContext();

		//Custom Events
		public event EventHandler<EventArgs> SavedDatabase;
		protected virtual void OnSavedDatabase()
		{
			SavedDatabase?.Invoke(this, EventArgs.Empty);
		}
		//-------------------
		public frmAddContact()
		{
			InitializeComponent();

			txtAddressType.Items.Add("Home");
			txtAddressType.Items.Add("Work");

			txtPhoneType.Items.Add("Home");
			txtPhoneType.Items.Add("Mobile");
			txtPhoneType.Items.Add("Work");

			txtAddressType.SelectedIndex = 0;
			txtPhoneType.SelectedIndex = 0;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveAndClose();
		}

		#region OnKeyDown
		void CheckKeyPress(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
				SaveAndClose();
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void btnSave_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void btnCancel_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtName_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtAdress_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtZipCode_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtCity_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void txtEmail_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}

		private void dtpBirthday_KeyDown(object sender, KeyEventArgs e)
		{
			CheckKeyPress(sender, e);
		}
		#endregion

		private void SaveAndClose()
		{
			if(txtName.Text.Trim().Length > 0)
			{
				var newContact = new Contact();

				newContact.Name = txtName.Text;

				newContact.Addresses = new List<Address>() { new Address() { Address1 = txtAddress.Text, ZipCode = txtZipCode.Text, City = txtCity.Text, Country = txtCountry.Text, Type = new AddressType(){ Type = txtAddressType.Text } } };

				newContact.PhoneNumbers = new List<PhoneNumber>() { new PhoneNumber() { Number = txtPhoneNr.Text, Type = new PhoneType() { Type = txtPhoneType.Text } } };

				db.Contacts.Add(newContact);
				db.SaveChanges();

				OnSavedDatabase();
				this.Close();
			}
			else
			{
				Timer timer = new Timer();
				timer.Interval = 3000;
				timer.Enabled = true;
				timer.Tick += new EventHandler(FadeWarningText);
				lblName.ForeColor = Color.Red;
				lblWarning.ForeColor = Color.Red;
				lblWarning.Text = "Name Required!";
			}
		}

		private void FadeWarningText(object sender, EventArgs e)
		{
			lblWarning.Text = "";
			lblName.ForeColor = Color.Black;
		}
	}
}

