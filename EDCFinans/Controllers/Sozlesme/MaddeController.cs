using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Controllers.Sozlesme
{
    public class MaddeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Madde_Listeleme()
        {
            return View();
        }
        public IActionResult Madde_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Madde_Ekle(int a)
        {
            return View();
        }
        public IActionResult Madde_Duzenle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Madde_Duzenle(int a)
        {
            return View();
        }
        public IActionResult Madde_DurumDegistir()
        {
            return View();
        }
        public IActionResult Madde_Sil()
        {
            return View();
        }
    }
}
