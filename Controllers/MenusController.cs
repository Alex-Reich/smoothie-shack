using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smoothie_shack.Models;
using smoothie_shack.Interfaces;

namespace smoothie_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        List<IPurchasable> Menu = Program.MenuItems;

        // GET api/smoothies
        [HttpGet]
        public IEnumerable<IPurchasable> Get()
        {
            return Menu;
        }

        // GET api/smoothies/5
        [HttpGet("{id}")]
        public IPurchasable Get(int id)
        {
            if (id > -1 && id < Menu.Count)
            {
                return Menu[id];
            }
            return null;
        }

        // POST api/smoothies
        [HttpPost]
        public List<IPurchasable> Post([FromBody]IPurchasable newMenuItem)
        {
            if (ModelState.IsValid)
            {
                Menu.Add(newMenuItem);
                return Menu;
            }
            return null;
        }

        // PUT api/smoothies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/smoothies/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
