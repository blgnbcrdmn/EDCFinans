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
    public class DepoController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public DepoController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> Depo_Listeleme()
        {
            var response = await _serviceProvider.DepoListele();
            return View(response);
        }

        public async Task<IActionResult> Depo_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Depo_Ekle(Depo depo)
        {
            var request = _mapper.Map<DepoEkle>(depo);
            var response = await _serviceProvider.DepoEkle(request);
            return RedirectToAction("Depo_Listeleme");
        }

        [HttpPost]
        public async Task<IActionResult> Depo_Duzenle(Depo depo)
        {
            var request = _mapper.Map<DepoEkle>(depo);
            var response = await _serviceProvider.DepoDuzenle(request);
            return RedirectToAction("Depo_Listeleme");
        }

        [HttpGet]
        public async Task<IActionResult> Depo_Duzenle(int id)
        {
            var response = await _serviceProvider.DepoGetir(id);
            return View(response);
        }

        public async Task<IActionResult> Depo_DurumDegistir(int id)
        {
            Depo depo = await _serviceProvider.DepoGetir(id);
            depo.Durum = !depo.Durum;
            var request = _mapper.Map<DepoEkle>(depo);
            await _serviceProvider.DepoDuzenle(request);
            return RedirectToAction("Depo_Listeleme");
        }

        public async Task<IActionResult> Depo_Sil()
        {
            return View();
        }

    }
}
