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
    public class PersonelController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public PersonelController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> Personel_Listeleme()
        {

            var response = await _serviceProvider.PersonelListele();
            return View(response);
        }

        public async Task<IActionResult> Personel_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Personel_Ekle(Personel personel)
        {
            var request = _mapper.Map<PersonelEkle>(personel);
            var response = await _serviceProvider.PersonelEkle(request);
            return RedirectToAction("Personel_Listeleme");
        }

        public async Task<IActionResult> Personel_Duzenle(int id)
        {
            var response = await _serviceProvider.PersonelGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Personel_Duzenle(Personel personel)
        {
            var request = _mapper.Map<PersonelEkle>(personel);
            var response = await _serviceProvider.PersonelDuzenle(request);
            return RedirectToAction("Personel_Listeleme");
        }

        public async Task<IActionResult> Personel_DurumDegistir(int id)
        {
            var model = await _serviceProvider.PersonelGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<PersonelEkle>(model);
            await _serviceProvider.PersonelDuzenle(request);
            return RedirectToAction("Personel_Listeleme");
        }

        public async Task<IActionResult> Personel_Sil()
        {
            return View();
        }
    }
}
