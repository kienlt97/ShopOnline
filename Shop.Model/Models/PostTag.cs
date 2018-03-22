using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
	public class PostTag
	{
		[Key]
		public int PostID { get; set; }

		[Key]
		[Column(TypeName = "varchar")]
		[MaxLength(50)]
		public string TagID { get; set; }

		[ForeignKey("PostID")]
		public virtual Post Pots { get; set; }

		[ForeignKey("TagID")]
		public virtual Tag Tags { get; set; }
	}
}
