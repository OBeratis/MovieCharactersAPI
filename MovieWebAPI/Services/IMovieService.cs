using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieWebAPI.Services
{
    public interface IMovieService
    {
        public Task UpdateMovieCharactersAsync(int movieId, List<int> characters);
        public bool MovieExists(int id);
    }
}
