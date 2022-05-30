using AutoMapper;
using EDCFinans.Models.Finans;
using EDCFinans.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Models
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Depo, DepoEkle>();
            CreateMap<DepoEkle, Depo>();

            CreateMap<Fatura, FaturaEkle>();
            CreateMap<FaturaEkle, Fatura>();

            CreateMap<GelirGider, GelirGiderEkle>();
            CreateMap<GelirGiderEkle, GelirGider>();

            CreateMap<GelirGiderTuru, GelirGiderTuruEkle>();
            CreateMap<GelirGiderTuruEkle, GelirGiderTuru>();

            CreateMap<Maas, MaasEkle>();
            CreateMap<MaasEkle, Maas>();

            CreateMap<Meslek, MeslekEkle>();
            CreateMap<MeslekEkle, Meslek>();

            CreateMap<ParaBirimi, ParaBirimiEkle>();
            CreateMap<ParaBirimiEkle, ParaBirimi>();

            CreateMap<Personel, PersonelEkle>();
            CreateMap<PersonelEkle, Personel>();

            CreateMap<Sehir, SehirEkle>();
            CreateMap<SehirEkle, Sehir>();

            CreateMap<Siparis, SiparisEkle>();
            CreateMap<SiparisEkle, Siparis>();

            CreateMap<SiparisDetay, SiparisDetayEkle>();
            CreateMap<SiparisDetayEkle, SiparisDetay>();

            CreateMap<SiparisDurum, SiparisDurumEkle>();
            CreateMap<SiparisDurumEkle, SiparisDurum>();

            CreateMap<Sirket, SirketEkle>();
            CreateMap<SirketEkle, Sirket>();

            CreateMap<Stok, StokEkle>();
            CreateMap<StokEkle, Stok>();

            CreateMap<Ulke, UlkeEkle>();
            CreateMap<UlkeEkle, Ulke>();

            CreateMap<UrunDetay, UrunDetayEkle>();
            CreateMap<UrunDetayEkle, UrunDetay>();

            CreateMap<Urun, UrunEkle>();
            CreateMap<UrunEkle, Urun>();
        }
    }
}
