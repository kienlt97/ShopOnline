﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
	[Table("SystemConfigs")]
	public class SystemConfig
	{
		[Key]
		public int ID { get; set; }

		[Required]
		[Column(TypeName ="varchar")]
		[MaxLength(50)]
		public string Name { get; set; }

		[MaxLength(50)]
		public string ValueString { get; set; }

		public int ValueInt { get; set; }
	}
}