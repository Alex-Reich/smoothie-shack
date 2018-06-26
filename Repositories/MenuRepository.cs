using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using smoothie_shack.Models;

namespace smoothie_shack.Repositories
{
    public class MenuRepository
    {

        private readonly IDbConnection _db;

        public MenuRepository(IDbConnection db)
        {
            _db = db;
        }
        public IEnumerable<Menu> GetAll()
        {
            return _db.Query<Menu>("SELECT * FROM menus");
        }
        public Menu GetById(int id)
        {
            return _db.Query<Menu>("SELECT * FROM menus WHERE id=@id", new{id}).FirstOrDefault();
        }
        public Menu AddMenu(Menu newMenu)
        {
            int id = _db.ExecuteScalar<int>(@"
            INSERT INTO menus (name, price, description)
            Values(@Name, @Price, @Description);
            SELECT LAST_INSERT_ID()", newMenu);
            newMenu.Id = id;
            return newMenu;
        }

        // Edit

        // Delete

    }
}