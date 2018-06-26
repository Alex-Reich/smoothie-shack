using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smoothie_shack.Models;

namespace smoothie_shack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SandwichesController : ControllerBase
  {
    List<Sandwich> Sandwiches = Program.Sandwiches;

    // GET api/sandwiches
    [HttpGet]
    public ActionResult<IEnumerable<Sandwich>> Get()
    {
      return Sandwiches;
    }

    // GET api/sandwiches/5
    [HttpGet("{id}")]
    public ActionResult<Sandwich> Get(int id)
    {
      if (id > -1 && id < Sandwiches.Count)
      {
        return Sandwiches[id];
      }
      return null;
    }

    // POST api/sandwiches
    [HttpPost]
    public ActionResult<List<Sandwich>> Post([FromBody]Sandwich newSandwich)
    {
      if (ModelState.IsValid)
      {
        Sandwiches.Add(newSandwich);
        return Sandwiches;
      }
      return null;
    }

    // PUT api/sandwiches/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/sandwiches/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
