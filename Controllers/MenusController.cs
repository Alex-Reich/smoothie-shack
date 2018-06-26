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
    public class MenusController : ControllerBase
    {
        // List<Menu> Menus = Program.Menus;
        private readonly MenuRepository db;
        public MenusController(MenuRepository repo)
        {
            db = repo;
        }
        // GET api/menus
        [HttpGet]
        public IEnumerable<Menu> Get()
        {
            return db.GetAll();
        }

        // GET api/menus/5
        [HttpGet("{id}")]
        public Menu Get(int id)
        {
            return db.GetById(id);
        }

        // POST api/menus
        [HttpPost]
        public Menu Post([FromBody]Menu newMenu)
        {
            if (ModelState.IsValid)
            {
              return db.AddMenu(newMenu);
            }
            return null;
        }

        // PUT api/menus/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/menus/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
