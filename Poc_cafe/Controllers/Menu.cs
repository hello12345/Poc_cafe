using Microsoft.AspNetCore.Mvc;
using Poc_cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc_cafe.Controllers
{
    public class Menu : Controller
    {
        public IActionResult Index()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item()
            {
                img = "bas.png",
                name = "name2",
                price = 50,
                Catagory= "Catagory1"
            });
            items.Add(new Item()
            {
                img = "bas.png",
                name = "name3",
                price = 50,
                Catagory = "Catagory2"
            });

            return View(items);
        }
    }
}
