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
        private static List<HtmlString> waffles = new List<HtmlString>();

        public IActionResult Index()
        {
            DateTime date = DateTime.Now;
            return View(date);
        }

        public IActionResult Waffler(int ID)
        {
            waffles.Clear();
            for (int i = 0; i < ID; i++)
            {
                var waffle = WaffleEngine.Html(2, true, false);
                HtmlString waffle2 = new HtmlString(waffle);
                waffles.Add(waffle2);
            }

            return View(waffles);
        }

        
    }
}