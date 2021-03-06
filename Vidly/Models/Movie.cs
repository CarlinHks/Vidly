﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
	public class Movie
	{
		public int Id { get; set; }
		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		[Required]
		[StringLength(255)]
		public string Detail { get; set; }
		public GenreType GenreType { get; set; }
		public DateTime RealeaseDateTime { get; set; }
		public DateTime AddDateTime { get; set; }
		public int Stock { get; set; }
	}
}