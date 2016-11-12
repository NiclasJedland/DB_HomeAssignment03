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
		public List<Adress> Adress { get; set; }
		public List<PhoneNumber> PhoneNumber { get; set; }

		public Person() { }

		public Person(int contactId, string name, List<Adress> adress, List<PhoneNumber> phoneNumber)
		{
			ContactId = contactId;
			Name = name;
			Adress = adress;
			PhoneNumber = phoneNumber;			
		}

		public override string ToString()
		{
			return Name;
		}

	}
}
