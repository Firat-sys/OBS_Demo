using BusinessLayer.Abstruct;
using DataAccessLayer.Abstruct;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class OgretimUyesiManager : IOgretimGorevlisiService
    {
        IOgretimUyesiDal _ogretimUyesiDal;

    

        public OgretimUyesiManager(IOgretimUyesiDal ogretimUyesiDal)
        {
            _ogretimUyesiDal = ogretimUyesiDal;
        }

        public void OgretimUyesiAdd(OgretimUyesi ogretimUyesi)
        {
            _ogretimUyesiDal.Insert(ogretimUyesi);
        }

        public void OgretimUyesiDelete(OgretimUyesi ogretimUyesi)
        {
            _ogretimUyesiDal.Delete(ogretimUyesi);
        }

        public OgretimUyesi OgretimUyesiGetId(int Id)
        {
            return _ogretimUyesiDal.GetById(Id);
        }

        public List<OgretimUyesi> OgretimUyesiListAll()
        {
            return _ogretimUyesiDal.GetList();
        }

        public void OgretimUyesiUpdate(OgretimUyesi ogretimUyesi)
        {
            _ogretimUyesiDal.Update(ogretimUyesi);
        }
    }
}
