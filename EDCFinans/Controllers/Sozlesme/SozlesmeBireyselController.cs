using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Controllers.Sozlesme
{
    public class SozlesmeBireyselController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SozlesmeBireysel_Listeleme()
        {
            return View();
        }
        public IActionResult SozlesmeBireysel_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeBireysel_Ekle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeBireysel_Duzenle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeBireysel_Duzenle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeBireysel_DurumDegistir()
        {
            return View();
        }
        public IActionResult SozlesmeBireysel_Sil()
        {
            return View();
        }
    }
}
