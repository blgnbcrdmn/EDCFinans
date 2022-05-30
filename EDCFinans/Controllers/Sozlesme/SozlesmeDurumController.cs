using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Controllers.Sozlesme
{
    public class SozlesmeDurumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SozlesmeDurum_Listeleme()
        {
            return View();
        }
        public IActionResult SozlesmeDurum_Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeDurum_Ekle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeDurum_Duzenle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SozlesmeDurum_Duzenle(int a)
        {
            return View();
        }
        public IActionResult SozlesmeDurum_DurumDegistir()
        {
            return View();
        }
        public IActionResult SozlesmeDurum_Sil()
        {
            return View();
        }
    }
}
