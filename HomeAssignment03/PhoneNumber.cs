using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAssignment03
{
	public partial class PhoneNumber
	{
		public int PhoneNumberId { get; set; }
		public string Number { get; set; }
		public virtual PhoneType Type { get; set; }
	}
}
