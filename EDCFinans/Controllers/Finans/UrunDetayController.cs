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
    public class UrunDetayController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public UrunDetayController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> UrunDetay_Listeleme()
        {

            var response = await _serviceProvider.UrunDetayListele();
            return View(response);
        }

        public async Task<IActionResult> UrunDetay_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UrunDetay_Ekle(UrunDetay urunDetay)
        {
            var request = _mapper.Map<UrunDetayEkle>(urunDetay);
            var response = await _serviceProvider.UrunDetayEkle(request);
            return RedirectToAction("UrunDetay_Listeleme");
        }

        public async Task<IActionResult> UrunDetay_Duzenle(int id)
        {
            var response = await _serviceProvider.UrunDetayGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> UrunDetay_Duzenle(UrunDetay urunDetay)
        {
            var request = _mapper.Map<UrunDetayEkle>(urunDetay);
            var response = await _serviceProvider.UrunDetayDuzenle(request);
            return RedirectToAction("UrunDetay_Listeleme");
        }

        public async Task<IActionResult> UrunDetay_DurumDegistir()
        {
            return View();
        }

        public async Task<IActionResult> UrunDetay_Sil()
        {
            return View();
        }
    }
}
