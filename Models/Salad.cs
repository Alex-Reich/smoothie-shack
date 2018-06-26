using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using smoothie_shack.Interfaces;

namespace smoothie_shack.Models
{
  public class Salad : IPurchasable
  {
    [Required]
    [Range(1, 100)]
    public decimal Price { get; set; }

    [Required]
    [MinLength(10)]
    [MaxLength(100)]
    public string Name { get; set; }
    public string Description {get; set;}
    List<string> Ingredients {get; set;} 


    public Salad(decimal price, string name, string description, List<string> ingredients)
    {
        Price = price;
        Name = name;
        Description = description;
        Ingredients = ingredients;
    }
  }
}