using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly IRepository _repository;
        public GenresController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public List<Genre>   Get()
        {
            return _repository.GetAllGenres();
        }
    }
}