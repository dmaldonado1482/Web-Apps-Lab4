using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaffleGenerator;
using Microsoft.AspNetCore.Html;

namespace Lab4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            DateTime date = DateTime.Now;
            return View(date);
        }

        public IActionResult Waffler()
        {
            var waffle = WaffleEngine.Html(2, true, false);
            HtmlString waffle2 = new HtmlString(waffle);
            return View(waffle2);
        }

        
    }
}