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
    public class SiparisController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public SiparisController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> Siparis_Listeleme()
        {

            var response = await _serviceProvider.SiparisListele();
            return View(response);
        }

        public async Task<IActionResult> Siparis_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Siparis_Ekle(Siparis siparis)
        {
            var request = _mapper.Map<SiparisEkle>(siparis);
            var response = await _serviceProvider.SiparisEkle(request);
            return RedirectToAction("Siparis_Listeleme");
        }

        public async Task<IActionResult> Siparis_Duzenle(int id)
        {
            var response = await _serviceProvider.SiparisGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Siparis_Duzenle(Siparis siparis)
        {
            var request = _mapper.Map<SiparisEkle>(siparis);
            var response = await _serviceProvider.SiparisDuzenle(request);
            return RedirectToAction("Siparis_Listeleme");
        }

        public async Task<IActionResult> Siparis_DurumDegistir(int id)
        {
            var model = await _serviceProvider.SiparisGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<SiparisEkle>(model);
            await _serviceProvider.SiparisDuzenle(request);
            return RedirectToAction("Siparis_Listeleme");
        }

        public async Task<IActionResult> Siparis_Sil()
        {
            return View();
        }
    }
}
