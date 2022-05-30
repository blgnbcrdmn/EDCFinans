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
    public class ParaBirimiController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public ParaBirimiController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> ParaBirimi_Listeleme()
        {

            var response = await _serviceProvider.ParaBirimiListele();
            return View(response);
        }

        public async Task<IActionResult> ParaBirimi_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ParaBirimi_Ekle(ParaBirimi paraBirimi)
        {
            var request = _mapper.Map<ParaBirimiEkle>(paraBirimi);
            var response = await _serviceProvider.ParaBirimiEkle(request);
            return RedirectToAction("ParaBirimi_Listeleme");
        }

        public async Task<IActionResult> ParaBirimi_Duzenle(int id)
        {
            var response = await _serviceProvider.ParaBirimiGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> ParaBirimi_Duzenle(ParaBirimi paraBirimi)
        {
            var request = _mapper.Map<ParaBirimiEkle>(paraBirimi);
            var response = await _serviceProvider.ParaBirimiDuzenle(request);
            return RedirectToAction("ParaBirimi_Listeleme");
        }

        public async Task<IActionResult> ParaBirimi_DurumDegistir(int id)
        {
            var model = await _serviceProvider.ParaBirimiGetir(id);
            model.Durum = !model.Durum;
            var request = _mapper.Map<ParaBirimiEkle>(model);
            await _serviceProvider.ParaBirimiDuzenle(request);
            return RedirectToAction("ParaBirimi_Listeleme");
        }

        public async Task<IActionResult> ParaBirimi_Sil()
        {
            return View();
        }
    }
}
