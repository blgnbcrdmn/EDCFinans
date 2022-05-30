using EDCFinans.Models.Finans;
using EDCFinans.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EDCFinans.Models.Provider
{
    public class EDCFinansServiceProvider : IEDCFinansServiceProvider
    {
        private readonly HttpClient _httpClient; 
        public EDCFinansServiceProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Depo> DepoDuzenle(DepoEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Depo/DepoDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Depo>();
        }

        public async Task<Depo> DepoEkle(DepoEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Depo/DepoEkle", request);

            return await response.Content.ReadFromJsonAsync<Depo>();
        }

        public async Task<Depo> DepoGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Depo>($"Depo/DepoGetir?id={id}");
        }

        public async Task<List<Depo>> DepoListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Depo>>("Depo/DepoListele");
        }

        public async Task<Fatura> FaturaDuzenle(FaturaEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Fatura/FaturaDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Fatura>();
        }

        public async Task<Fatura> FaturaEkle(FaturaEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Fatura/FaturaEkle", request);

            return await response.Content.ReadFromJsonAsync<Fatura>();
        }

        public async Task<Fatura> FaturaGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Fatura>($"Fatura/FaturaGetir?id={id}");
        }

        public async Task<List<Fatura>> FaturaListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Fatura>>("Fatura/FaturaListele");
        }

        public async Task<GelirGiderTuru> GeliGiderTuruDuzenle(GelirGiderTuruEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("GelirGiderTuru/GeliGiderTuruDuzenle", request);

            return await response.Content.ReadFromJsonAsync<GelirGiderTuru>();
        }

        public async Task<GelirGider> GelirGiderDuzenle(GelirGiderEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("GelirGider/GelirGiderDuzenle", request);

            return await response.Content.ReadFromJsonAsync<GelirGider>();
        }

        public async Task<GelirGider> GelirGiderEkle(GelirGiderEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("GelirGider/GelirGiderEkle", request);

            return await response.Content.ReadFromJsonAsync<GelirGider>();
        }

        public async Task<GelirGider> GelirGiderGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<GelirGider>($"GelirGider/GelirGiderGetir?id={id}");
        }

        public async Task<List<GelirGider>> GelirGiderListele()
        {
            return await _httpClient.GetFromJsonAsync<List<GelirGider>>("GelirGider/GelirGiderListele");
        }

        public async Task<GelirGiderTuru> GelirGiderTurEkle(GelirGiderTuruEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("GelirGiderTuru/GelirGiderTurEkle", request);

            return await response.Content.ReadFromJsonAsync<GelirGiderTuru>();
        }

        public async Task<GelirGiderTuru> GelirGiderTuruGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<GelirGiderTuru>($"GelirGiderTuru/GelirGiderTuruGetir?id={id}");
        }

        public async Task<List<GelirGiderTuru>> GelirGiderTuruListele()
        {
            return await _httpClient.GetFromJsonAsync<List<GelirGiderTuru>>("GelirGiderTuru/GelirGiderTuruListele");
        }

        public async Task<Maas> MaasDuzenle(MaasEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Maas/MaasDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Maas>();
        }

        public async Task<Maas> MaasEkle(MaasEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Maas/MaasEkle", request);

            return await response.Content.ReadFromJsonAsync<Maas>();
        }

        public async Task<Maas> MaasGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Maas>($"Maas/MaasGetir?id={id}");
        }

        public async Task<List<Maas>> MaasListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Maas>>("Maas/MaasListele");
        }

        public async Task<Meslek> MeslekDuzenle(MeslekEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Meslek/MeslekDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Meslek>();
        }

        public async Task<Meslek> MeslekEkle(MeslekEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Meslek/MeslekEkle", request);

            return await response.Content.ReadFromJsonAsync<Meslek>();
        }

        public async Task<Meslek> MeslekGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Meslek>($"Meslek/MeslekGetir?id={id}");
        }

        public async Task<List<Meslek>> MeslekListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Meslek>>("Meslek/MeslekListele");
        }

        public async Task<ParaBirimi> ParaBirimiDuzenle(ParaBirimiEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("ParaBirimi/ParaBirimiDuzenle", request);

            return await response.Content.ReadFromJsonAsync<ParaBirimi>();
        }

        public async Task<ParaBirimi> ParaBirimiEkle(ParaBirimiEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("ParaBirimi/ParaBirimiEkle", request);

            return await response.Content.ReadFromJsonAsync<ParaBirimi>();
        }

        public async Task<ParaBirimi> ParaBirimiGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<ParaBirimi>($"ParaBirimi/ParaBirimiGetir?id={id}");
        }

        public async Task<List<ParaBirimi>> ParaBirimiListele()
        {
            return await _httpClient.GetFromJsonAsync<List<ParaBirimi>>("ParaBirimi/ParaBirimiListele");
        }

        public async Task<Personel> PersonelDuzenle(PersonelEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Personel/PersonelDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Personel>();
        }

        public async Task<Personel> PersonelEkle(PersonelEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Personel/PersonelEkle", request);

            return await response.Content.ReadFromJsonAsync<Personel>();
        }

        public async Task<Personel> PersonelGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Personel>($"Personel/PersonelGetir?id={id}");
        }

        public async Task<List<Personel>> PersonelListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Personel>>("Personel/PersonelListele");
        }

        public async Task<Sehir> SehirDuzenle(SehirEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Sehir/SehirDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Sehir>();
        }

        public async Task<Sehir> SehirEkle(SehirEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Sehir/SehirEkle", request);

            return await response.Content.ReadFromJsonAsync<Sehir>();
        }

        public async Task<Sehir> SehirGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Sehir>($"Sehir/SehirGetir?id={id}");
        }

        public async Task<List<Sehir>> SehirListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Sehir>>("Sehir/SehirListele");
        }

        public async Task<SiparisDetay> SiparisDetayDuzenle(SiparisDetayEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("SiparisDetay/SiparisDetayDuzenle", request);

            return await response.Content.ReadFromJsonAsync<SiparisDetay>();
        }

        public async Task<SiparisDetay> SiparisDetayEkle(SiparisDetayEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("SiparisDetay/SiparisDetayEkle", request);

            return await response.Content.ReadFromJsonAsync<SiparisDetay>();
        }

        public async Task<SiparisDetay> SiparisDetayGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<SiparisDetay>($"SiparisDetay/SiparisDetayGetir?id={id}");
        }

        public async Task<List<SiparisDetay>> SiparisDetayListele()
        {
            return await _httpClient.GetFromJsonAsync<List<SiparisDetay>>("SiparisDetay/SiparisDetayListele");
        }

        public async Task<SiparisDurum> SiparisDurumDuzenle(SiparisDurumEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("SiparisDurum/SiparisDurumDuzenle", request);

            return await response.Content.ReadFromJsonAsync<SiparisDurum>();
        }

        public async Task<SiparisDurum> SiparisDurumEkle(SiparisDurumEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("SiparisDurum/SiparisDurumEkle", request);

            return await response.Content.ReadFromJsonAsync<SiparisDurum>();
        }

        public async Task<SiparisDurum> SiparisDurumGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<SiparisDurum>($"SiparisDurum/SiparisDurumGetir?id={id}");
        }

        public async Task<List<SiparisDurum>> SiparisDurumListele()
        {
            return await _httpClient.GetFromJsonAsync<List<SiparisDurum>>("SiparisDurum/SiparisDurumListele");
        }

        public async Task<Siparis> SiparisDuzenle(SiparisEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Siparis/SiparisDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Siparis>();
        }

        public async Task<Siparis> SiparisEkle(SiparisEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Siparis/SiparisEkle", request);

            return await response.Content.ReadFromJsonAsync<Siparis>();
        }

        public async Task<Siparis> SiparisGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Siparis>($"Siparis/SiparisGetir?id={id}");
        }

        public async Task<List<Siparis>> SiparisListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Siparis>>("Siparis/SiparisListele");
        }

        public async Task<Sirket> SirketDuzenle(SirketEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Sirket/SirketDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Sirket>();
        }

        public async Task<Sirket> SirketEkle(SirketEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Sirket/SirketEkle", request);

            return await response.Content.ReadFromJsonAsync<Sirket>();
        }

        public async Task<Sirket> SirketGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Sirket>($"Sirket/SirketGetir?id={id}");
        }

        public async Task<List<Sirket>> SirketListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Sirket>>("Sirket/SirketListele");
        }

        public async Task<Stok> StokDuzenle(StokEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Stok/StokDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Stok>();
        }

        public async Task<Stok> StokEkle(StokEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Stok/StokEkle", request);

            return await response.Content.ReadFromJsonAsync<Stok>();
        }

        public async Task<Stok> StokGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Stok>($"Stok/StokGetir?id={id}");
        }

        public async Task<List<Stok>> StokListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Stok>>("Stok/StokListele");
        }

        public async Task<Ulke> UlkeDuzenle(UlkeEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Ulke/UlkeDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Ulke>();
        }

        public async Task<Ulke> UlkeEkle(UlkeEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Ulke/UlkeEkle", request);

            return await response.Content.ReadFromJsonAsync<Ulke>();
        }

        public async Task<Ulke> UlkeGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Ulke>($"Ulke/UlkeGetir?id={id}");
        }

        public async Task<List<Ulke>> UlkeListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Ulke>>("Ulke/UlkeListele");
        }

        public async Task<UrunDetay> UrunDetayDuzenle(UrunDetayEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("UrunDetay/UrunDetayDuzenle", request);

            return await response.Content.ReadFromJsonAsync<UrunDetay>();
        }

        public async Task<UrunDetay> UrunDetayEkle(UrunDetayEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("UrunDetay/UrunDetayEkle", request);

            return await response.Content.ReadFromJsonAsync<UrunDetay>();
        }

        public async Task<UrunDetay> UrunDetayGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<UrunDetay>($"UrunDetay/UrunDetayGetir?id={id}");
        }

        public async Task<List<UrunDetay>> UrunDetayListele()
        {
            return await _httpClient.GetFromJsonAsync<List<UrunDetay>>("UrunDetay/UrunDetayListele");
        }

        public async Task<Urun> UrunDuzenle(UrunEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("Urun/UrunDuzenle", request);

            return await response.Content.ReadFromJsonAsync<Urun>();
        }

        public async Task<Urun> UrunEkle(UrunEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("Urun/UrunEkle", request);

            return await response.Content.ReadFromJsonAsync<Urun>();
        }

        public async Task<Urun> UrunGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<Urun>($"Urun/UrunGetir?id={id}");
        }

        public async Task<UrunKategori> UrunKategoriDuzenle(UrunKategoriEkle request)
        {
            var response = await _httpClient.PutAsJsonAsync("UrunKategori/UrunKategoriDuzenle", request);

            return await response.Content.ReadFromJsonAsync<UrunKategori>();
        }

        public async Task<UrunKategori> UrunKategoriEkle(UrunKategoriEkle request)
        {
            var response = await _httpClient.PostAsJsonAsync("UrunKategori/UrunKategoriEkle", request);

            return await response.Content.ReadFromJsonAsync<UrunKategori>();
        }

        public async Task<UrunKategori> UrunKategoriGetir(int id)
        {
            return await _httpClient.GetFromJsonAsync<UrunKategori>($"UrunKategori/UrunKategoriGetir?id={id}");
        }

        public async Task<List<UrunKategori>> UrunKategoriListele()
        {
            return await _httpClient.GetFromJsonAsync<List<UrunKategori>>("UrunKategori/UrunKategoriListele");
        }

        public async Task<List<Urun>> UrunListele()
        {
            return await _httpClient.GetFromJsonAsync<List<Urun>>("Urun/UrunListele");
        }
    }
}
