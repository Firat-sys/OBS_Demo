using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstruct
{
   public interface IOgretimGorevlisiService
    {
        void OgretimUyesiAdd(OgretimUyesi ogretimUyesi);
        void OgretimUyesiDelete(OgretimUyesi ogretimUyesi);
        void OgretimUyesiUpdate(OgretimUyesi ogretimUyesi);
        List<OgretimUyesi> OgretimUyesiListAll();
        OgretimUyesi OgretimUyesiGetId(int Id);
    }
}
