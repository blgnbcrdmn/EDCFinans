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
    public class SirketController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public SirketController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }
        public async Task<IActionResult> Sirket_Listeleme()
        {
            var response = await _serviceProvider.SirketListele();
            return View(response);
        }

        public async Task<IActionResult> Sirket_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Sirket_Ekle(Sirket sirket)
        {
            var request = _mapper.Map<SirketEkle>(sirket);
            var response = await _serviceProvider.SirketEkle(request);
            return RedirectToAction("Sirket_Listeleme");
        }

        public async Task<IActionResult> Sirket_Duzenle(int id)
        {
            var response = await _serviceProvider.SirketGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Sirket_Duzenle(Sirket sirket)
        {
            var request = _mapper.Map<SirketEkle>(sirket);
            var response = await _serviceProvider.SirketDuzenle(request);
            return RedirectToAction("Sirket_Listeleme");
        }

        public async Task<IActionResult> Sirket_DurumDegistir(int id)
        {
            var model = await _serviceProvider.SirketGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<SirketEkle>(model);
            await _serviceProvider.SirketDuzenle(request);
            return RedirectToAction("Sirket_Listeleme");
        }

        public async Task<IActionResult> Sirket_Sil()
        {
            return View();
        }
    }
}
