using Microsoft.AspNetCore.Mvc;
using Poc_cafe.Data;
using Poc_cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc_cafe.Controllers
{
    public class MenuController : Controller
    {
        private AppDbContext context;
        public MenuController(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public IActionResult Index()
        {
            var items = context.Items.ToList();
            return View(items);
        }
    }
}
