using DataAccessLayer.Abstruct;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class OgretimUyesiRepository : IOgretimUyesiDal
    {
        Context c = new Context();
        public void AddOgretimUyesi(OgretimUyesi ogretimUyesi)
        {
            c.Add(ogretimUyesi);
            c.SaveChanges();
        }

        public void Delete(OgretimUyesi t)
        {
            throw new NotImplementedException();
        }

        public void DeleteOgretimUyesi(OgretimUyesi ogretimUyesi)
        {
            c.Remove(ogretimUyesi);
            c.SaveChanges();
        }

        public OgretimUyesi GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OgretimUyesi> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(OgretimUyesi t)
        {
            throw new NotImplementedException();
        }

        public OgretimUyesi OgretimUyesiGetId(int Id)
        {
            return c.OgretimUyesis.Find(Id);
        }

        public List<OgretimUyesi> OgretimUyesiList()
        {
            return c.OgretimUyesis.ToList();
        }

        public void Update(OgretimUyesi t)
        {
            throw new NotImplementedException();
        }

        public void UpdateOgretimUyesi(OgretimUyesi ogretimUyesi)
        {
            c.Update(ogretimUyesi);
            c.SaveChanges();
        }
    }
}
