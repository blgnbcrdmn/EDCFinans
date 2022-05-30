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
    public class FaturaController : Controller
    {

        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public FaturaController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }
        public async Task<IActionResult> Fatura_Listeleme()
        {
            var response = await _serviceProvider.FaturaListele();
            return View(response);
        }

        public async Task<IActionResult> Fatura_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Fatura_Ekle(Fatura fatura)
        {
            var request = _mapper.Map<FaturaEkle>(fatura);
            await _serviceProvider.FaturaEkle(request);
            return RedirectToAction("Fatura_Listeleme");
        }

        public async Task<IActionResult> Fatura_Duzenle(int id)
        {
            var response = await _serviceProvider.FaturaGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Fatura_Duzenle(Fatura fatura)
        {
            var request = _mapper.Map<FaturaEkle>(fatura);
            await _serviceProvider.FaturaDuzenle(request);
            return RedirectToAction("Fatura_Listeleme");
        }

        public async Task<IActionResult> Fatura_DurumDegistir(int id)
        {
            Fatura fatura = await _serviceProvider.FaturaGetir(id);
            fatura.Durum = !fatura.Durum;
            var request = _mapper.Map<FaturaEkle>(fatura);
            await _serviceProvider.FaturaDuzenle(request);
            return RedirectToAction("Fatura_Listeleme");
        }

        public async Task<IActionResult> Fatura_Sil()
        {
            return View();
        }
    }
}
