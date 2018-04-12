using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2part2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2part2.Controllers
{
    [Produces("application/json")]
    [Route("api/Movies")]
    public class MoviesController : Controller
    {
        private ModelMovie dc;

        public MoviesController(ModelMovie dc)
        {
            this.dc =dc;
        }
        // GET: api/Populars
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return dc.Movie.ToList();
        }

        // GET: api/Movies/5
        [HttpGet("{id}", Name = "Set")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Movies
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Movies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
