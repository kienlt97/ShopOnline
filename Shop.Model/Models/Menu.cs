using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
	[Table("Menus")]
    public class Menu
    {
		[Key]
		public int ID { get; set; }

		[Required]
		[MaxLength(50)]
		public string Name { get; set; }

		[Required]
		[MaxLength(250)]
		public string URL { get; set; }

		public int? Display { get; set; }
		public int? GroupID { get; set; }

		[MaxLength(10)]
		public string Target { get; set; }
		public bool Status { get; set; }

		[ForeignKey("GroupID")]
		public virtual MenuGroup MenuGroups { get; set; }
	}
}
