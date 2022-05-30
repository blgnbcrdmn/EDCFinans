using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Controllers.Sozlesme
{
    public class SozlesmeTuruController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SozlesmeTuru_Listeleme()
        {
            return View();
        }
        public IActionResult SozlesmeTuru_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeTuru_Ekle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeTuru_Duzenle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeTuru_Duzenle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeTuru_DurumDegistir()
        {
            return View();
        }
        public IActionResult SozlesmeTuru_Sil()
        {
            return View();
        }
    }
}
