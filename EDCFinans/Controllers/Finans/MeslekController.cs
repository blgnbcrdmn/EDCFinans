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
    public class MeslekController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public MeslekController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> Meslek_Listeleme()
        {

            var response = await _serviceProvider.MeslekListele();
            return View(response);
        }

        public async Task<IActionResult> Meslek_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Meslek_Ekle(Meslek meslek)
        {
            var request = _mapper.Map<MeslekEkle>(meslek);
            var response = await _serviceProvider.MeslekEkle(request);
            return RedirectToAction("Meslek_Listeleme");
        }

        public async Task<IActionResult> Meslek_Duzenle(int id)
        {
            var response = await _serviceProvider.MeslekGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Meslek_Duzenle(Meslek meslek)
        {
            var request = _mapper.Map<MeslekEkle>(meslek);
            var response = await _serviceProvider.MeslekDuzenle(request);
            return RedirectToAction("Meslek_Listeleme");
        }

        public async Task<IActionResult> Meslek_DurumDegistir(int id)
        {
            var model = await _serviceProvider.MeslekGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<MeslekEkle>(model);
            await _serviceProvider.MeslekDuzenle(request);
            return RedirectToAction("Meslek_Listeleme");
        }

        public async Task<IActionResult> Meslek_Sil()
        {
            return View();
        }
    }
}
