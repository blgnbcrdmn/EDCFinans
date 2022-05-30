using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Controllers.Sozlesme
{
    public class MaddeKategoriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MaddeKategori_Listeleme()
        {
            return View();
        }
        public IActionResult MaddeKategori_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MaddeKategori_Ekle(int a)
        {
            return View();
        }
        public IActionResult MaddeKategori_Duzenle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MaddeKategori_Duzenle(int a)
        {
            return View();
        }
        public IActionResult MaddeKategori_DurumDegistir()
        {
            return View();
        }
        public IActionResult MaddeKategori_Sil()
        {
            return View();
        }
    }
}
