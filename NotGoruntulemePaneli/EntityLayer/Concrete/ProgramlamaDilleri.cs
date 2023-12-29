using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class ProgramlamaDilleri
    {[Key]
        public int ProgramlamaDilleriID { get; set; }
        public int Vize1 { get; set; }
        public int Vize2 { get; set; }
        public int Final { get; set; }
        public int OgretimUyesiID { get; set; }
        public OgretimUyesi OgretimUyesi { get; set; }
        public List<Ogrenci> Ogrencis { get; set; }
    }
}
