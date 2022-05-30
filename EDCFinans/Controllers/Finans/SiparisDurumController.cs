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
    public class SiparisDurumController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public SiparisDurumController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }
        public async Task<IActionResult> SiparisDurum_Listeleme()
        {

            var response = await _serviceProvider.SiparisDurumListele();
            return View(response);
        }

        public async Task<IActionResult> SiparisDurum_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SiparisDurum_Ekle(SiparisDurum siparisDurum)
        {
            var request = _mapper.Map<SiparisDurumEkle>(siparisDurum);
            var response = await _serviceProvider.SiparisDurumEkle(request);
            return RedirectToAction("SiparisDurum_Listeleme");
        }

        public async Task<IActionResult> SiparisDurum_Duzenle(int id)
        {
            var response = await _serviceProvider.SiparisDurumGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> SiparisDurum_Duzenle(SiparisDurum siparisDurum)
        {
            var request = _mapper.Map<SiparisDurumEkle>(siparisDurum);
            var response = await _serviceProvider.SiparisDurumDuzenle(request);
            return RedirectToAction("SiparisDurum_Listeleme");
        }

        public async Task<IActionResult> SiparisDurum_DurumDegistir(int id)
        {
            var model = await _serviceProvider.SiparisDurumGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<SiparisDurumEkle>(model);
            await _serviceProvider.SiparisDurumDuzenle(request);
            return RedirectToAction("SiparisDurum_Listeleme");
        }

        public async Task<IActionResult> SiparisDurum_Sil()
        {
            return View();
        }
    }
}
