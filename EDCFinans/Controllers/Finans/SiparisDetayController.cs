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
    public class SiparisDetayController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public SiparisDetayController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> SiparisDetay_Listeleme()
        {

            var response = await _serviceProvider.SiparisDetayListele();
            return View(response);
        }

        public async Task<IActionResult> SiparisDetay_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SiparisDetay_Ekle(SiparisDetay siparisDetay)
        {
            var request = _mapper.Map<SiparisDetayEkle>(siparisDetay);
            var response = await _serviceProvider.SiparisDetayEkle(request);
            return RedirectToAction("SiparisDetay_Listeleme");
        }

        public async Task<IActionResult> SiparisDetay_Duzenle(int id)
        {
            var response = await _serviceProvider.SiparisDetayGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> SiparisDetay_Duzenle(SiparisDetay siparisDetay)
        {
            var request = _mapper.Map<SiparisDetayEkle>(siparisDetay);
            var response = await _serviceProvider.SiparisDetayDuzenle(request);
            return RedirectToAction("SiparisDetay_Listeleme");
        }

    }
}
