using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment03
{
	public class Person
	{
		public int ContactId { get; set; }
		public string Name { get; set; }
		public Dictionary<string, string> Adress { get; set; }
		public Dictionary<string, string> PhoneNumber { get; set; }

		public Person() { }

		public Person(string name, string adress, string zipCode, string city, string phoneNumber, string email, DateTime birthday)
		{
			/*
			Name = name;
			Adress = adress;
			ZipCode = zipCode;
			City = city;
			PhoneNumber = phoneNumber;
			Email = email;
			Birthday = birthday;
			*/
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
