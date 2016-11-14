using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace HomeAssignment03
{
	public partial class Address
	{
		public int AddressId { get; set; }
		public string Address1 { get; set; }
		public string ZipCode { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public virtual AddressType Type { get; set; }
	}
}
