using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Controllers.Sozlesme
{
    public class SozlesmeKisiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SozlesmeKisi_Listeleme()
        {
            return View();
        }
        public IActionResult SozlesmeKisi_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeKisi_Ekle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeKisi_Duzenle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeKisi_Duzenle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeKisi_DurumDegistir()
        {
            return View();
        }
        public IActionResult SozlesmeKisi_Sil()
        {
            return View();
        }
    }
}
