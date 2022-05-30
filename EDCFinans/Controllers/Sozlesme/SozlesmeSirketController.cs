using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Controllers.Sozlesme
{
    public class SozlesmeSirketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SozlesmeSirket_Listeleme()
        {
            return View();
        }
        public IActionResult SozlesmeSirket_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeSirket_Ekle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeSirket_Duzenle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeSirket_Duzenle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeSirket_DurumDegistir()
        {
            return View();
        }
        public IActionResult SozlesmeSirket_Sil()
        {
            return View();
        }
    }
}
