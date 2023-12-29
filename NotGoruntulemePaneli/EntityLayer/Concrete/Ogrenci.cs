using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSinifi { get; set; }
        public MeslekiInglizce meslekiInglizce { get; set; }
        public ProgramlamaDilleri programlama { get; set; }
        public SayisalAnaliz sayisalAnaliz { get; set; }
        public VeriTabaniYsSis veriTabani { get; set; }
        public VeriYapilari VeriYapilari { get; set; }
        public int VeriY_Id { get; set; }
        public int VeriTabanıYsSisID { get; set; }
        public int SayısalAnalizID { get; set; }
        public int ProgramlamaDilleriID { get; set; }
        public int MeslekiIngizceID { get; set; }
    }
}
