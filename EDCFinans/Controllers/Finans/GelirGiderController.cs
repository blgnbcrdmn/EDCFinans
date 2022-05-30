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
    public class GelirGiderController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public GelirGiderController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> GelirGider_Listeleme()
        {

            var response = await _serviceProvider.GelirGiderListele();
            return View(response);
        }

        public async Task<IActionResult> GelirGider_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GelirGider_Ekle(GelirGider gelirGider)
        {
            var request = _mapper.Map<GelirGiderEkle>(gelirGider);
            await _serviceProvider.GelirGiderEkle(request);
            return RedirectToAction("GelirGider_Listeleme");
        }
        

        public async Task<IActionResult> GelirGider_Duzenle(int id)
        {
            var response = await _serviceProvider.GelirGiderGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> GelirGider_Duzenle(GelirGider gelirGider)
        {
            var request = _mapper.Map<GelirGiderEkle>(gelirGider);
            await _serviceProvider.GelirGiderDuzenle(request);
            return RedirectToAction("GelirGider_Listeleme");
        }

        public async Task<IActionResult> GelirGider_DurumDegistir(int id)
        {
            var model = await _serviceProvider.GelirGiderGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<GelirGiderEkle>(model);
            await _serviceProvider.GelirGiderDuzenle(request);
            return RedirectToAction("GelirGider_Listeleme");
        }

        public async Task<IActionResult> GelirGider_Sil()
        {
            return View();
        }
    }
}
