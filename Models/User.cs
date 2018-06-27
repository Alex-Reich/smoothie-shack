using System.Collections.Generic;

namespace smoothie_shack.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Smoothie> MyFavs { get; set; }

    }
}