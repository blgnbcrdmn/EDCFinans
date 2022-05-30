﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDCFinans.Request
{
    public class PersonelEkle
    {
        public int Id { get; set; }
        public int MeslekId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime İseGirisTarihi { get; set; }
        public DateTime İstenCikisTarihi { get; set; }
        public bool Durum { get; set; }
    }
}