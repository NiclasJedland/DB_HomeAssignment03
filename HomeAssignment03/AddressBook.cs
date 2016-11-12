using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HomeAssignment03
{
	public partial class Adressbook : Form
	{
		public Adressbook()
		{
			InitializeComponent();
		}

		#region Events
		private void Adressbook_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'contactBookDataSet.Contact' table. You can move, or remove it, as needed.
			UpdateList();
			dgAddress.BackgroundColor = SystemColors.Control;
			dgPhone.BackgroundColor = SystemColors.Control;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				var test = lstPeople.SelectedItem;
				if(MessageBox.Show("Remove Selected", "Remove " + lstPeople.SelectedItem + "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Timer timer = new Timer();
					timer.Interval = 3000;
					timer.Enabled = true;
					timer.Tick += new EventHandler(FadeWarningText);

					var toBeRemoved = lstPeople.SelectedItem;

					using(var db = new ContactBookEntities())
					{
						db.Entry(toBeRemoved).State = EntityState.Deleted;

						db.SaveChanges();
					}

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

		private void btnSaveChanges_Click(object sender, EventArgs e)
		{
			if(lstPeople.SelectedItem != null)
			{
				if(MessageBox.Show("Update " + lstPeople.SelectedItem, "Save changes?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					using(var db = new ContactBookEntities())
					{
						Timer timer = new Timer();
						timer.Interval = 3000;
						timer.Enabled = true;
						timer.Tick += new EventHandler(FadeWarningText);


						var updatedUser = (Contact)lstPeople.SelectedItem;

						var original = db.Contacts.Find(updatedUser.ContactId);

						if(original != null)
						{
							db.Entry(original).CurrentValues.SetValues(updatedUser);
							//	db.SaveChanges();
						}





						/*

						var toBeUpdated = new Person();//(Person)lstPeople.SelectedItem;
						var currentItem = (Person)lstPeople.SelectedItem;

						toBeUpdated.Name = txtName.Text;
						toBeUpdated.ContactId = currentItem.ContactId;

						for(int i = 0; i < dgAddress.Rows.Count; i++)
						{
							//toBeUpdated.Adress.Add(new Adress
							//{
							//	Type = dgAddress[0, i].Value.ToString(),
							//	Adress1 = dgAddress[1, i].Value.ToString(),
							//	ZipCode = dgAddress[2, i].Value.ToString(),
							//	City = dgAddress[3, i].Value.ToString(),
							//	Country = dgAddress[4, i].Value.ToString(),
							//	AdressId = (int)dgAddress[5, i].Value
							//});
						}

						for(int i = 0; i < dgPhone.Rows.Count; i++)
						{
							var phoneNumber = new PhoneNumber
							{
								Number = dgPhone.Rows[i].Cells[0].Value.ToString(),
								Type = dgPhone.Rows[i].Cells[1].Value.ToString(),
								PhoneId = (int)dgPhone.Rows[i].Cells[2].Value
							};

							toBeUpdated.PhoneNumber.Add(phoneNumber);

						}




						//db.Entry(toBeUpdated).State = EntityState.Modified;

						//db.SaveChanges();




						lblWarning.ForeColor = Color.Green;
						lblWarning.Text = toBeUpdated.Name + " Updated!";
												*/

					}

					UpdateList();
				}
				txtSearch.Text = "";
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
					dgPhone.Rows.Add(phoneNumber.Type, phoneNumber.Number, phoneNumber.PhoneId);
				}

				foreach(var item in selectedItem.ContactAdresses)
				{
					var address = item.Adress;
					dgAddress.Rows.Add(address.Type, address.Adress1, address.ZipCode, address.City, address.Country, address.AdressId);
				}
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
			lstPeople.Items.Clear();

			txtName.Text = "";

			var contacts = new List<Contact>();

			using(var db = new ContactBookEntities())
			{
				db.Configuration.LazyLoadingEnabled = false;

				lstPeople.DataSource = db.Contacts.OrderBy(s => s.Name).ToList();
				dgAddress.DataSource = db.Adresses.OrderBy(s => s.Adress1).ToList();
				dgPhone.DataSource = db.PhoneNumbers.OrderBy(s => s.Number).ToList();


				/*
				contacts = db.Contacts.OrderBy(s => s.Name).ToList();

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

				foreach(var item in contacts)
				{
					lstPeople.Items.Add(item);
				}

				if(lstPeople.Items.Count == 0)
				{
					dgPhone.Rows.Clear();
					dgAddress.Rows.Clear();
				}
				else
					lstPeople.SelectedIndex = 0;
					*/
			}
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



}