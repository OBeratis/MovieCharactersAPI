using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
		[StringLength(120)]
		public string Genre { get; set; }
	    public int ReleaseYear { get; set; }
		[StringLength(50)]
		public string Director { get; set; }
		[StringLength(256)]
		public string PictureUrl { get; set; }
		[StringLength(256)]
		public string Trailer { get; set; }
    }
}
