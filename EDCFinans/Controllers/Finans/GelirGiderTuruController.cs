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
    public class GelirGiderTuruController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public GelirGiderTuruController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> GelirGiderTuru_Listeleme()
        {

            var response = await _serviceProvider.GelirGiderTuruListele();
            return View(response);
        }

        public async Task<IActionResult> GelirGiderTuru_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GelirGiderTuru_Ekle(GelirGiderTuru gelirGiderTuru)
        {
            var request = _mapper.Map<GelirGiderTuruEkle>(gelirGiderTuru);
            await _serviceProvider.GelirGiderTurEkle(request);
            return RedirectToAction("GelirGiderTuru_Listeleme");
        }

        public async Task<IActionResult> GelirGiderTuru_Duzenle(int id)
        {
            var response = await _serviceProvider.GelirGiderTuruGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> GelirGiderTuru_Duzenle(GelirGiderTuru gelirGiderTuru)
        {
            var request = _mapper.Map<GelirGiderTuruEkle>(gelirGiderTuru);
            await _serviceProvider.GeliGiderTuruDuzenle(request);
            return RedirectToAction("GelirGiderTuru_Listeleme");
        }

        public async Task<IActionResult> GelirGiderTuru_DurumDegistir(int id)
        {
            var model = await _serviceProvider.GelirGiderTuruGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<GelirGiderTuruEkle>(model);
            await _serviceProvider.GeliGiderTuruDuzenle(request);
            return RedirectToAction("GelirGiderTuru_Listeleme");
        }

        public async Task<IActionResult> GelirGiderTuru_Sil()
        {
            return View();
        }
    }
}
