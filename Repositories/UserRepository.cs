namespace smoothie_shack.Repositories
{
    public class UserRepository
    {
        
    }
}

// using System.Collections.Generic;
// using System.Data;
// using System.Linq;
// using Dapper;
// using smoothie_shack.Models;

// namespace smoothie_shack.Repositories
// {
//     public class UserRepository
//     {

        // private readonly IDbConnection _db;

//         public UserRepository(IDbConnection db)
//         {
//             _db = db;
//         }
//         public IEnumerable<User> GetAll()
//         {
//             return _db.Query<User>("SELECT * FROM users");
//         }
//         public User GetById(int id)
//         {
//             return _db.Query<User>("SELECT * FROM users WHERE id=@id", new{id}).FirstOrDefault();
//         }
//         public User AddUser(User newUser)
//         {
//             int id = _db.ExecuteScalar<int>(@"
//             INSERT INTO users (name, price, description)
//             Values(@Name, @Price, @Description);
//             SELECT LAST_INSERT_ID()", newUser);
//             newUser.Id = id;
//             return newUser;
//         }

//         // Edit

//         // Delete

//     }
// }