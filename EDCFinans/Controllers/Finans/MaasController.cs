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
    public class MaasController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public MaasController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> Maas_Listeleme()
        {

            var response = await _serviceProvider.MaasListele();
            return View(response);
        }

        public async Task<IActionResult> Maas_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Maas_Ekle(Maas maas)
        {
            var request = _mapper.Map<MaasEkle>(maas);
            var response = await _serviceProvider.MaasEkle(request);
            return RedirectToAction("Maas_Listeleme");
        }

        public async Task<IActionResult> Maas_Duzenle(int id)
        {
            var response = await _serviceProvider.MaasGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Maas_Duzenle(Maas maas)
        {
            var request = _mapper.Map<MaasEkle>(maas);
            var response = await _serviceProvider.MaasDuzenle(request);
            return RedirectToAction("Maas_Listeleme");
        }

        public async Task<IActionResult> Maas_DurumDegistir(int id)
        {
            var model = await _serviceProvider.MaasGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<MaasEkle>(model);
            await _serviceProvider.MaasDuzenle(request);
            return RedirectToAction("Maas_Listeleme");
        }

        public async Task<IActionResult> Maas_Sil()
        {
            return View();
        }
    }
}
