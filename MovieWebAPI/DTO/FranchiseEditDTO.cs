using System.Collections.Generic;
using MovieWebAPI.Models;

namespace MovieWebAPI.DTO
{
    public class FranchiseEditDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
