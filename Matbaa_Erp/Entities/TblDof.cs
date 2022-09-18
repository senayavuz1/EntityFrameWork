using System;
using System.Collections.Generic;

#nullable disable

namespace Matbaa_Erp.Entities
{
    public partial class TblDof
    {
        public string Dofkod { get; set; }
        public string Doftipi { get; set; }
        public short Dofno { get; set; }
        public DateTime? Tarih { get; set; }
        public string Dfof { get; set; }
        public string Firmakod { get; set; }
        public string Urunkod { get; set; }
        public int Siparisno { get; set; }
        public float Miktar { get; set; }
        public string Irsaliyeno { get; set; }
        public string Tanimi { get; set; }
        public string Hatanedenibildirim { get; set; }
        public string Hatanedeni { get; set; }
        public string Eylembildirim { get; set; }
        public string Eylem { get; set; }
        public string Eylemplanlama { get; set; }
        public DateTime? Sevktarihi { get; set; }
        public string Raporno { get; set; }
        public string Acanpersonel { get; set; }
        public string Acankisi { get; set; }
        public string Acanbolum { get; set; }
        public string Ilgilikisi { get; set; }
        public string Ilgilibolum { get; set; }
        public bool KontrolKapat { get; set; }
        public DateTime Kapattarih { get; set; }
        public string Kapatankisi { get; set; }
        public string Sonuc { get; set; }
        public bool Dfgerekli { get; set; }
        public string Dfno { get; set; }
        public string Onayliyankisi { get; set; }
        public DateTime Onaytarih { get; set; }
        public string Ek1 { get; set; }
        public string Ek2 { get; set; }
        public string Ek3 { get; set; }
        public string Ek4 { get; set; }
        public string Olusturanadisoyadi { get; set; }
        public DateTime Olusturmatarihi { get; set; }
    }
}
