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
    public class SehirController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public SehirController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> Sehir_Listeleme()
        {

            var response = await _serviceProvider.SehirListele();
            return View(response);
        }

        public async Task<IActionResult> Sehir_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Sehir_Ekle(Sehir sehir)
        {
            var request = _mapper.Map<SehirEkle>(sehir);
            var response = await _serviceProvider.SehirEkle(request);
            return RedirectToAction("Sehir_Listeleme");
        }

        public async Task<IActionResult> Sehir_Duzenle(int id)
        {
            var response = await _serviceProvider.SehirGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Sehir_Duzenle(Sehir sehir)
        {
            var request = _mapper.Map<SehirEkle>(sehir);
            var response = await _serviceProvider.SehirDuzenle(request);
            return RedirectToAction("Sehir_Listeleme");
        }

        public async Task<IActionResult> Sehir_DurumDegistir(int id)
        {
            var model = await _serviceProvider.PersonelGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<SehirEkle>(model);
            await _serviceProvider.SehirDuzenle(request);
            return RedirectToAction("Sehir_Listeleme");
        }

        public async Task<IActionResult> Sehir_Sil()
        {
            return View();
        }
    }
}
