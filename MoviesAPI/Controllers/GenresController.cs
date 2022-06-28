using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
    [Route("api/controller")]
    public class GenresController : ControllerBase
    {
        private readonly IRepository _repository;
        public GenresController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public List<Genre> Get()
        {
            return _repository.GetAllGenres();
        }
        [HttpGet("{id}")]
        public Genre Get(int id)
        {
            var genre = _repository.GetGenreById(id);
            if (genre==null)
            {
                //return NotFound();
            }
            return genre;
        }
        [HttpPost]
        public List<Genre> Post()
        {
            return _repository.GetAllGenres();
        }
        [HttpPut]
        public List<Genre> Put()
        {
            return _repository.GetAllGenres();
        }
        [HttpDelete]
        public List<Genre> Delete()
        {
            return _repository.GetAllGenres();
        }




    }
}