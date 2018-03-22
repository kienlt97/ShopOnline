using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
	public class VisitorStatistic
	{

		[Key]
		public int ID { get; set; }

		[Required]
		public DateTime VisittedDate { get; set; }

		[MaxLength(50)]
		public string IPAddress { get; set; }
	}
}
