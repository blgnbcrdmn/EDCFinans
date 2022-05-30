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
    public class UlkeController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public UlkeController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> Ulke_Listeleme()
        {

            var response = await _serviceProvider.UlkeListele();
            return View(response);
        }

        public async Task<IActionResult> Ulke_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ulke_Ekle(Ulke ulke)
        {
            var request = _mapper.Map<UlkeEkle>(ulke);
            var response = await _serviceProvider.UlkeEkle(request);
            return RedirectToAction("Ulke_Listeleme");
        }

        public async Task<IActionResult> Ulke_Duzenle(int id)
        {
            var response = await _serviceProvider.UlkeGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Ulke_Duzenle(Ulke ulke)
        {
            var request = _mapper.Map<UlkeEkle>(ulke);
            var response = await _serviceProvider.UlkeDuzenle(request);
            return RedirectToAction("Ulke_Listeleme");
        }

        public async Task<IActionResult> Ulke_DurumDegistir()
        {
            return View();
        }

        public async Task<IActionResult> Ulke_Sil()
        {
            return View();
        }
    }
}
