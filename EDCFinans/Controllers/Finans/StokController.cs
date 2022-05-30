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
    public class StokController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public StokController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> Stok_Listeleme()
        {

            var response = await _serviceProvider.StokListele();
            return View(response);
        }

        public async Task<IActionResult> Stok_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Stok_Ekle(Stok stok)
        {
            var request = _mapper.Map<StokEkle>(stok);
            var response = await _serviceProvider.StokEkle(request);
            return RedirectToAction("Stok_Listeleme");
        }

        public async Task<IActionResult> Stok_Duzenle(int id)
        {
            var response = await _serviceProvider.StokGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Stok_Duzenle(Stok stok)
        {
            var request = _mapper.Map<StokEkle>(stok);
            var response = await _serviceProvider.StokDuzenle(request);
            return RedirectToAction("Stok_Listeleme");
        }

        public async Task<IActionResult> Stok_Sil()
        {
            return View();
        }
    }
}
