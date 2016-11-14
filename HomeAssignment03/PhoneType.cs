using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment03
{
	public class PhoneType
	{
		public int PhoneTypeId { get; set; }
		public string Type { get; set; }
	}
}
