using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Controllers.Sozlesme
{
    public class SozlesmeKurumsalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SozlesmeKurumsal_Listeleme()
        {
            return View();
        }
        public IActionResult SozlesmeKurumsal_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeKurumsal_Ekle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeKurumsal_Duzenle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeKurumsal_Duzenle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeKurumsal_DurumDegistir()
        {
            return View();
        }
        public IActionResult SozlesmeKurumsal_Sil()
        {
            return View();
        }
    }
}
