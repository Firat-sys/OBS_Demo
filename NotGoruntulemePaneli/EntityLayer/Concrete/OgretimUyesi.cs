using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class OgretimUyesi
    {
        [Key]
        public int OgretimUyesiID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int DersID { get; set; }
        public string EPosta { get; set; }
        public List<MeslekiInglizce> MeslekiInglizces { get; set; }
        public List<ProgramlamaDilleri> ProgramlamaDilleris { get; set; }
        public List<SayisalAnaliz> SayisalAnalizs { get; set; }
        public List<VeriTabaniYsSis> VeriTabaniYsSes { get; set; }
        public List<VeriYapilari> VeriYapilaris { get; set; }
    }
}
