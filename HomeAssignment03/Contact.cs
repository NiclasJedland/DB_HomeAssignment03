using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace HomeAssignment03
{
	public partial class Contact
	{
		public int ContactId { get; set; }
		public string Name { get; set; }
		public virtual ICollection<Address> Addresses { get; set; }
		public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
	}
}
