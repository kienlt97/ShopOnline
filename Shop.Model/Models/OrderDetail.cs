﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
	[Table("OrderDetails")]
	public class OrderDetail
	{
		[Key]
		public int OrderID { get; set; }

		[Key]
		public int ProductID { get; set; }

		public int Quanlyti { get; set; }

		[ForeignKey("OrderID")]
		public virtual Order Orders { get; set; }

		[ForeignKey("ProductID")]
		public virtual Product Products { get; set; }
	}
}