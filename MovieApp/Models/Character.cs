using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Character
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        [StringLength(25)]
	    public string Alias { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
        [StringLength(256)]
        public string PictureUrl { get; set; }
    }
}
