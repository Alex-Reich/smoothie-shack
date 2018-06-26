using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using smoothie_shack.Models;
using smoothie_shack.Interfaces;

namespace smoothie_shack
{
    public class Program
    {
        //BAD CODE, DONT DO THIS!!!
        public static List<Smoothie> Smoothies = new List<Smoothie>()
            {
                new Smoothie(4.99m, "Mango Madness", "Yo dawg we heard you like mangos",new List<string>(){
                    "Mangos",
                    "Madness"
                }),
                new Smoothie(4.99m, "Green Monster", "We put in all the veggies", new List<string>(){
                    "kale",
                    "spinach",
                    "healthy stuff"
                }),
                new Smoothie(5.99m, "Not So Healthy", "Basically a Milkshake", new List<string>(){
                    "ice cream",
                    "chocolate",
                    "peanut butter",
                    "eaters remorse"
                })
            };
        public static List<Sandwich> Sandwiches = new List<Sandwich>()
    {
        new Sandwich(7.50m, "Super Sub", "DO NOT pair with Kryptonite. Bad things will happen.", new List<string>(){
            "Kryptonian Tears",
            "Pastrami",
            "Ghost Peppers"
        }),
        new Sandwich(15m, "The Big One", "24in of everything you could ever want.", new List<string>(){
            "All the proteins",
            "All the veggies"
        })
    };
        public static List<Salad> Salads = new List<Salad>()
    {
        new Salad(2m, "Happy Accident", "Yesterday's leftovers combined.", new List<string>(){
            "Lettuce",
            "Peach Pits",
            "Splash of Spiced Rum"
        }),
        new Salad(25m, "Chef's Salad", "Literally the Chef's Salad that he couldn't finish.", new List<string>(){
            "Scraps o' meat",
            "Used napkin"
        })
    };
        public static List<IPurchasable> MenuItems = new List<IPurchasable>();
        public static void CreateMenu()
        {
            foreach (var s in Smoothies)
            {
                MenuItems.Add(s);
            }
            foreach (var s in Sandwiches)
            {
                MenuItems.Add(s);
            }
            foreach (var s in Salads)
            {
                MenuItems.Add(s);
            }
        }


        public static void Main(string[] args)
        {
            CreateMenu();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
