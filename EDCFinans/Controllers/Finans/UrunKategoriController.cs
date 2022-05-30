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
    public class UrunKategoriController : Controller
    {
        private readonly IEDCFinansServiceProvider _serviceProvider;
        private readonly IMapper _mapper;
        public UrunKategoriController(IEDCFinansServiceProvider serviceProvider, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _mapper = mapper;
        }

        public async Task<IActionResult> UrunKategori_Listeleme()
        {

            var response = await _serviceProvider.UrunKategoriListele();
            return View(response);
        }

        public async Task<IActionResult> UrunKategori_Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UrunKategori_Ekle(UrunKategori urunKategori)
        {
            var request = _mapper.Map<UrunKategoriEkle>(urunKategori);
            var response = await _serviceProvider.UrunKategoriEkle(request);
            return RedirectToAction("UrunKategori_Listeleme");
        }

        public async Task<IActionResult> UrunKategori_Duzenle(int id)
        {
            var response = await _serviceProvider.UrunKategoriGetir(id);
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> UrunKategori_Duzenle(UrunKategori urunKategori)
        {
            var request = _mapper.Map<UrunKategoriEkle>(urunKategori);
            var response = await _serviceProvider.UrunKategoriDuzenle(request);
            return RedirectToAction("UrunKategori_Listeleme");
        }

        public async Task<IActionResult> UrunKategori_DurumDegistir()
        {
            return View();
        }

        public async Task<IActionResult> UrunKategori_Sil()
        {
            return View();
        }
    }
}
