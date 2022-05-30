using AutoMapper;
using EDCFinans.Models.Finans;
using EDCFinans.Models.Provider;
using EDCFinans.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Controllers
{
    public class UrunController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public UrunController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> Urun_Listeleme()
        {

            var response = await _serviceProvider.UrunListele();
            return View(response);
        }

        public async Task<IActionResult> Urun_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Urun_Ekle(Urun urun)
        {
            var request = _mapper.Map<UrunEkle>(urun);
            var response = await _serviceProvider.UrunEkle(request);
            return RedirectToAction("Urun_Listeleme");
        }

        public async Task<IActionResult> Urun_Duzenle(int id)
        {
            var response = await _serviceProvider.UrunGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Urun_Duzenle(Urun urun)
        {
            var request = _mapper.Map<UrunEkle>(urun);
            var response = await _serviceProvider.UrunDuzenle(request);
            return RedirectToAction("Urun_Listeleme");
        }

        public async Task<IActionResult> Urun_DurumDegistir()
        {
            return View();
        }

        public async Task<IActionResult> Urun_Sil()
        {
            return View();
        }
    }
}
