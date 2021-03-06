using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using smoothie_shack.Models;

namespace smoothie_shack.Repositories
{
    public class SaladRepository
    {

        private readonly IDbConnection _db;

        public SaladRepository(IDbConnection db)
        {
            _db = db;
        }
        public IEnumerable<Salad> GetAll()
        {
            return _db.Query<Salad>("SELECT * FROM salads");
        }
        public Salad GetById(int id)
        {
            return _db.Query<Salad>("SELECT * FROM salads WHERE id=@id", new{id}).FirstOrDefault();
        }
        public Salad AddSalad(Salad newSalad)
        {
            int id = _db.ExecuteScalar<int>(@"
            INSERT INTO salads (name, price, description)
            Values(@Name, @Price, @Description);
            SELECT LAST_INSERT_ID()", newSalad);
            newSalad.Id = id;
            return newSalad;
        }

        // Edit

        // Delete

    }
}