using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smoothie_shack.Models;
using smoothie_shack.Repositories;

namespace smoothie_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaladsController : Controller
    {
        // List<Salad> Salads = Program.Salads;
        private readonly SaladRepository db;
        public SaladsController(SaladRepository repo)
        {
            db = repo;
        }
        // GET api/salads
        [HttpGet]
        public IEnumerable<Salad> Get()
        {
            return db.GetAll();
        }

        // GET api/salads/5
        [HttpGet("{id}")]
        public Salad Get(int id)
        {
            return db.GetById(id);
        }

        // POST api/salads
        [HttpPost]
        public Salad Post([FromBody]Salad newSalad)
        {
            if (ModelState.IsValid)
            {
              return db.AddSalad(newSalad);
            }
            return null;
        }

        // PUT api/salads/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/salads/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
