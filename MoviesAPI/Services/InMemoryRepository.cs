using MoviesAPI.Entities;

namespace MoviesAPI.Services
{
    public class InMemoryRepository:IRepository
    {
        private List<Genre> _genres;
        private List<Genre> _gere;

        public InMemoryRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre(){Id=1,Name="Comaedy" },
                new Genre(){Id=2,Name="Action"}
            };
        }
        public List<Genre> GetAllGenres()
        {
            return _genres;
        }
    }
}
