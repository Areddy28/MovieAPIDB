using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPIDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        MoiveDAL md = new MoiveDAL();
        [HttpGet]
        public List<Movie> GetAllMovies()
        {
            return md.GetAllMovies();
        }


        [HttpGet("genre={value}")]

        public List<Movie> GetMoviesByGenre(string value)
        {
            return md.GetMoviesByGenre(value);
        }

    }

}
