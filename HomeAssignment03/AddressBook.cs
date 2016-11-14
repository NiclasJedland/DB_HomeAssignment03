using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace HomeAssignment03
{
	public partial class Adressbook : Form
	{
		ContactBookEntities db = new ContactBookEntities();

		public Adressbook()
		{
			InitializeComponent();

			/*
			using(var ctx = new PersonContext())
			{

				List<PhoneNumber> newPhone = new List<PhoneNumber>() { new PhoneNumber { Number = txtTelenr.Text } };
				PhoneType newNrType = new PhoneType() { NrType = ComboBoxTelefontyp.Text, PhoneNumber = newPhone };
				List<Address> newAddress = new List<Address>() { new Address { StreetAdress = txtAdress.Text, City = txtCity.Text, ZipCode = int.Parse(txtZipCode.Text) } };
				AddressType newAddressTyp = new AddressType() { Type = ComboboxAdresstyp.Text, Address = newAddress };
				Person newPerson = new Person() { Name = txtNamn.Text, AddressType = newAddressTyp, PhoneType = newNrType };
				ctx.Persons.Add(newPerson);
				ctx.SaveChanges();
			}
	*/
	}

		#region Events
		private void Adressbook_Load(object sender, EventArgs e)
		{
			UpdateList();
			dgPhone.BackgroundColor = SystemColors.Control;
			dgAddress.BackgroundColor = SystemColors.Control;
		}

		private void btnRemoveContact_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				if(MessageBox.Show("Remove Selected?", "Remove " + lstPeople.SelectedItem + "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Timer timer = new Timer();
					timer.Interval = 3000;
					timer.Enabled = true;
					timer.Tick += new EventHandler(FadeWarningText);

					var toBeRemoved = (Contact)lstPeople.SelectedItem;

					db.spDeleteContact(toBeRemoved.ContactId);

					lblWarning.ForeColor = Color.Red;
					lblWarning.Text = toBeRemoved + " Removed!";

					UpdateList();
				}
				txtSearch.Text = "";
			}
		}

		private void btnAddContact_Click(object sender, EventArgs e)
		{
			this.Hide();
			var newWindow = new frmAddContact();
			newWindow.Closed += (s, args) => this.Show();
			newWindow.SavedDatabase += OnSavedDatabase;
			newWindow.Show();
		}

		private void btnRemovePhone_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null && dgPhone.Rows.Count > 1)
			{
				if(MessageBox.Show("Remove Selected?", "Remove " + dgPhone.SelectedRows[0].Cells[1].Value + "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					var toBeRemoved = (Contact)lstPeople.SelectedItem;
					var contactPhoneID = int.Parse(dgPhone.SelectedRows[0].Cells[3].Value.ToString());

					db.spRemovePhoneNumber(contactPhoneID);

					UpdateList();
				}
			}
		}

		private void btnAddPhone_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				grpPhone.Visible = false;
				grpAddPhone.Visible = true;

				grpAddress.Visible = false;
				grpAddAddress.Visible = false;
			}
		}

		private void btnAddPhoneCancel_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				ResetAllTextFields();
			}
		}

		private void btnAddPhoneSave_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				var toBeUpdated = (Contact)lstPeople.SelectedItem;

				db.spInsertNewPhone(toBeUpdated.ContactId, txtPhoneNumber.Text, txtPhoneType.Text);

				ResetAllTextFields();

				UpdateList();
			}
		}

		private void btnRemoveAddress_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null && dgAddress.Rows.Count > 1)
			{
				if(MessageBox.Show("Remove Selected?", "Remove " + dgAddress.SelectedRows[0].Cells[1].Value + "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					var toBeRemoved = (Contact)lstPeople.SelectedItem;
					var contactAddressID = int.Parse(dgAddress.SelectedRows[0].Cells[6].Value.ToString());

					db.spRemoveAddress(contactAddressID);

					UpdateList();
				}
			}
		}

		private void btnAddAddress_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				grpAddAddress.Visible = true;
				grpAddress.Visible = false;

				grpAddPhone.Visible = false;
				grpPhone.Visible = false;
			}
		}

		private void btnAddAddressCancel_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				ResetAllTextFields();
			}
		}

		private void btnAddAddressSave_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				var toBeUpdated = (Contact)lstPeople.SelectedItem;

				db.spInsertNewAddress(toBeUpdated.ContactId, txtAddress.Text, txtZipCode.Text, txtCity.Text, txtCountry.Text, txtAddressType.Text);

				ResetAllTextFields();
				UpdateList();
			}
		}

		private void btnChangeName_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				if(MessageBox.Show("Change name?", "Change name to" + txtName.Text + "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					var toBeUpdated = (Contact)lstPeople.SelectedItem;
					toBeUpdated.Name = txtName.Text;

					db.Entry(toBeUpdated).State = EntityState.Modified;
					db.SaveChanges();

					UpdateList();
				}
			}
		}

		private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				dgPhone.Rows.Clear();
				dgAddress.Rows.Clear();

				var selectedItem = (Contact)lstPeople.SelectedItem;

				txtName.Text = selectedItem.Name;


				foreach(var item in selectedItem.ContactPhones)
				{
					var phoneNumber = item.PhoneNumber;
					dgPhone.Rows.Add(phoneNumber.Type, phoneNumber.Number, phoneNumber.PhoneId, item.ContactPhoneId);
				}

				foreach(var item in selectedItem.ContactAdresses)
				{
					var address = item.Adress;
					dgAddress.Rows.Add(address.Type, address.Adress1, address.ZipCode, address.City, address.Country, address.AdressId, item.ContactAdressId);
				}
			}
		}

		private void dgAddress_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			SaveChanges();
		}

		private void dgPhone_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			SaveChanges();
		}

		public void SaveChanges()
		{
			if(lstPeople.SelectedItem != null)
			{
				Timer timer = new Timer();
				timer.Interval = 3000;
				timer.Enabled = true;
				timer.Tick += new EventHandler(FadeWarningText);

				var toBeUpdated = (Contact)lstPeople.SelectedItem;

				int i = 0;
				foreach(var item in toBeUpdated.ContactAdresses)
				{
					item.Adress.Type = dgAddress.Rows[i].Cells[0].Value.ToString();
					item.Adress.Adress1 = dgAddress.Rows[i].Cells[1].Value.ToString();
					item.Adress.ZipCode = dgAddress.Rows[i].Cells[2].Value.ToString();
					item.Adress.City = dgAddress.Rows[i].Cells[3].Value.ToString();
					item.Adress.Country = dgAddress.Rows[i].Cells[4].Value.ToString();
					i++;
				}

				i = 0;
				foreach(var item in toBeUpdated.ContactPhones)
				{
					item.PhoneNumber.Type = dgPhone.Rows[i].Cells[0].Value.ToString();
					item.PhoneNumber.Number = dgPhone.Rows[i].Cells[1].Value.ToString();
					i++;
				}

				db.Entry(toBeUpdated).State = EntityState.Modified;
				db.SaveChanges();

				lblWarning.ForeColor = Color.Green;
				lblWarning.Text = toBeUpdated.Name + " Updated!";

				UpdateList();

				txtSearch.Text = "";
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			UpdateList();
		}
		#endregion

		#region Methods
		private void UpdateList()
		{
			db.Dispose();
			db = new ContactBookEntities();

			var selectedIndex = lstPeople.SelectedIndex;

			lstPeople.Items.Clear();
			dgPhone.Rows.Clear();
			dgAddress.Rows.Clear();

			txtName.Text = "";

			var people = db.Contacts.OrderBy(s => s.Name).ToList();

			if(txtSearch.Text.Length > 0)
			{
				var searchText = txtSearch.Text.Trim().ToLower();
				people = db.Contacts.Where(s =>
					s.Name.ToLower().Contains(searchText)
					|| s.ContactAdresses.Any(a => a.Adress.Adress1.Contains(searchText))
					|| s.ContactAdresses.Any(a => a.Adress.City.Contains(searchText))
					|| s.ContactAdresses.Any(a => a.Adress.Country.Contains(searchText))
					|| s.ContactAdresses.Any(a => a.Adress.ZipCode.Contains(searchText))
					|| s.ContactAdresses.Any(a => a.Adress.Type.Contains(searchText))
					|| s.ContactPhones.Any(a => a.PhoneNumber.Type.Contains(searchText))
					).OrderBy(s => s.Name).ToList();
			}

			foreach(var item in people)
			{
				lstPeople.Items.Add(item);
			}

			if(lstPeople.Items.Count == 0)
			{
				dgAddress.Rows.Clear();
				dgPhone.Rows.Clear();
			}

			if(txtSearch.Text.Length == 0)
				lstPeople.SelectedIndex = selectedIndex;
		}

		private void ResetAllTextFields()
		{
			grpAddAddress.Visible = false;
			grpAddress.Visible = true;

			txtAddress.Text = "";
			txtZipCode.Text = "";
			txtCity.Text = "";
			txtCountry.Text = "";
			txtAddressType.Text = "";

			grpPhone.Visible = true;
			grpAddPhone.Visible = false;

			txtPhoneNumber.Text = "";
			txtPhoneType.Text = "";
		}

		private void FadeWarningText(object sender, EventArgs e)
		{
			lblWarning.Text = "";
		}

		public void OnSavedDatabase(object source, EventArgs e)
		{
			UpdateList();
		}
		#endregion

		#region Keypress
		private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != '-'))
			{
				e.Handled = true;
			}
		}


		#endregion
	}

	public partial class Contact
	{
		public override string ToString()
		{
			return Name;
		}
	}

}