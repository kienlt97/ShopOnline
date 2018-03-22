using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
	[Table("Slides")]
	public class Slide
	{
		[Key]
		[MaxLength(50)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }

		[MaxLength(256)]
		[Required]
		public string Name { get; set; }

		[MaxLength(256)]
		public string Description { get; set; }

		[MaxLength(256)]
		public string Image { get; set; }

		[MaxLength(256)]
		public string URL { get; set; }

		public int? DispalyOrder { get; set; }
		public bool Status { get; set; }

	}
}
