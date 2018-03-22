using Shop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
	[Table("ProductCategories")]
	public class ProductCategorie:Auditable
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }

		[MaxLength(256)]
		[Required]
		public string Name { get; set; }

		[MaxLength(256)]
		[Required]
		public string Alias { get; set; }

		[MaxLength(256)]
		public string Description { get; set; }
		public int? ParentID { get; set; }
		public int? DisplayOder { get; set; }

		[MaxLength(256)]
		public string Image { get; set; }

		public bool? HomeFlag { get; set; }
		public virtual IEnumerable<Product> Products { get; set; }
	//	public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
	}
}
