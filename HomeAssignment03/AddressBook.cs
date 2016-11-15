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
		ContactContext db = new ContactContext();

		public Adressbook()
		{
			InitializeComponent();
			txtSearch.ForeColor = Color.Gray;
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

					var selectedItem = (Contact)lstPeople.SelectedItem;

					db.Contacts.Remove(selectedItem);

					db.SaveChanges();

					lblWarning.ForeColor = Color.Red;
					lblWarning.Text = selectedItem + " Removed!";

					UpdateList();
				}
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
					var selectedItem = (Contact)lstPeople.SelectedItem;
					var selectedPhone =(PhoneNumber)dgPhone.SelectedRows[0].Tag;

					selectedPhone.Type = null;
					selectedItem.PhoneNumbers.Remove(selectedPhone);

					db.Entry(selectedPhone).State = EntityState.Deleted;					
					db.Entry(selectedItem).State = EntityState.Modified;
					db.SaveChanges();

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
				var selectedItem = (Contact)lstPeople.SelectedItem;

				var newType = new PhoneType() { Type = txtPhoneType.Text };
				if(db.PhoneTypes.Any(s => s.Type.Trim().ToLower() == txtPhoneType.Text.Trim().ToLower()))
					newType = db.PhoneTypes.Where(s => s.Type.Trim().ToLower() == txtPhoneType.Text.Trim().ToLower()).FirstOrDefault();

				selectedItem.PhoneNumbers.Add(new PhoneNumber() { Number = txtPhoneNumber.Text, Type = newType });

				db.Entry(selectedItem).State = EntityState.Modified;
				db.SaveChanges();

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
					var selectedItem = (Contact)lstPeople.SelectedItem;
					var selectedAddress = (Address)dgAddress.SelectedRows[0].Tag;

					selectedAddress.Type = null;
					selectedItem.Addresses.Remove(selectedAddress);

					db.Entry(selectedAddress).State = EntityState.Deleted;
					db.Entry(selectedItem).State = EntityState.Modified;
					db.SaveChanges();

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
				var selectedItem = (Contact)lstPeople.SelectedItem;

				selectedItem.Addresses.Add(new Address() { Address1 = txtAddress.Text, ZipCode = txtZipCode.Text, City = txtCity.Text, Country = txtCountry.Text, Type = new AddressType() { Type = txtAddressType.Text } });

				var newType = new AddressType() { Type = txtAddressType.Text };
				if(db.AddressTypes.Any(s => s.Type.Trim().ToLower() == txtAddressType.Text.Trim().ToLower()))
					newType = db.AddressTypes.Where(s => s.Type.Trim().ToLower() == txtAddressType.Text.Trim().ToLower()).FirstOrDefault();

				db.Entry(selectedItem).State = EntityState.Modified;
				db.SaveChanges();

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
					var selectedItem = (Contact)lstPeople.SelectedItem;
					selectedItem.Name = txtName.Text;

					db.Entry(selectedItem).State = EntityState.Modified;
					db.SaveChanges();

					UpdateList();
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

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			UpdateList();
		}

		private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				dgPhone.Rows.Clear();
				dgAddress.Rows.Clear();

				var selectedItem = (Contact)lstPeople.SelectedItem;

				txtName.Text = selectedItem.Name;

				int i = 0;
				foreach(var item in selectedItem.PhoneNumbers)
				{
					dgPhone.Rows.Add(item.Type.Type, item.Number, item.PhoneNumberId);
					dgPhone.Rows[i].Tag = item;
					i++;
				}

				i = 0;
				foreach(var item in selectedItem.Addresses)
				{
					dgAddress.Rows.Add(item.Type.Type, item.Address1, item.ZipCode, item.City, item.Country, item.AddressId);
					dgAddress.Rows[i].Tag = item;
					i++;
				}
			}
		}
		#endregion

		#region Methods
		private void UpdateList()
		{
			db.Dispose();
			db = new ContactContext();

			var selectedIndex = lstPeople.SelectedIndex;

			lstPeople.Items.Clear();
			dgPhone.Rows.Clear();
			dgAddress.Rows.Clear();

			txtName.Text = "";

			var people = db.Contacts.OrderBy(s => s.Name).ToList();

			if(txtSearch.Text.Length > 0 && txtSearch.Text != "Search")
			{
				var searchText = txtSearch.Text.Trim().ToLower();
				people = db.Contacts.Where(s =>
					s.Name.ToLower().Contains(searchText)
					|| s.Addresses.Any(a => a.Address1.Contains(searchText))
					|| s.Addresses.Any(a => a.City.Contains(searchText))
					|| s.Addresses.Any(a => a.Country.Contains(searchText))
					|| s.Addresses.Any(a => a.ZipCode.Contains(searchText))
					|| s.Addresses.Any(a => a.Type.Type.Contains(searchText))
					|| s.PhoneNumbers.Any(a => a.Type.Type.Contains(searchText))
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

		public void SaveChanges()
		{
			if(lstPeople.SelectedItem != null)
			{
				Timer timer = new Timer();
				timer.Interval = 3000;
				timer.Enabled = true;
				timer.Tick += new EventHandler(FadeWarningText);

				var selectedItem = (Contact)lstPeople.SelectedItem;

				int i = 0;
				foreach(var item in selectedItem.Addresses)
				{
					item.Type.Type = dgAddress.Rows[i].Cells[0].Value.ToString();
					item.Address1 = dgAddress.Rows[i].Cells[1].Value.ToString();
					item.ZipCode = dgAddress.Rows[i].Cells[2].Value.ToString();
					item.City = dgAddress.Rows[i].Cells[3].Value.ToString();
					item.Country = dgAddress.Rows[i].Cells[4].Value.ToString();
					i++;
				}

				i = 0;
				foreach(var item in selectedItem.PhoneNumbers)
				{
					item.Type.Type = dgPhone.Rows[i].Cells[0].Value.ToString();
					item.Number = dgPhone.Rows[i].Cells[1].Value.ToString();
					i++;
				}

				db.Entry(selectedItem).State = EntityState.Modified;
				db.SaveChanges();

				lblWarning.ForeColor = Color.Green;
				lblWarning.Text = selectedItem.Name + " Updated!";

				UpdateList();

				txtSearch.Text = "";
			}
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

		private void lstPeople_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				btnRemoveContact.PerformClick();
			}
		}

		private void txtSearch_Enter(object sender, EventArgs e)
		{
			txtSearch.ForeColor = Color.Black;
			txtSearch.Text = "";
		}

		private void txtSearch_Leave(object sender, EventArgs e)
		{
			txtSearch.ForeColor = Color.Gray;
			txtSearch.Text = "Search";
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