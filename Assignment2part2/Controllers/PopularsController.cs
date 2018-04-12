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
    [Route("api/Populars")]
    public class PopularsController : Controller
    {
        private ModelMovie db;

        public PopularsController(ModelMovie db)
        {
            this.db = db;
        }
        // GET: api/Populars
        [HttpGet]
        public IEnumerable<Popular> Get()
        {
            return db.Popular.ToList();
        }
       

        // GET: api/Populars/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Populars
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Populars/5
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
