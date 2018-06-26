
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using smoothie_shack.Interfaces;

namespace smoothie_shack.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Title { get; set; }
        List<Smoothie> Smoothies { get; set; }
        List<Sandwich> Sandwiches { get; set; }
        List<Salad> Salads { get; set; }
        public Menu(string title)
        {
            Title = title;
            Smoothies = new List<Smoothie>();
            Sandwiches = new List<Sandwich>();
            Salads = new List<Salad>();
        }
    }
}