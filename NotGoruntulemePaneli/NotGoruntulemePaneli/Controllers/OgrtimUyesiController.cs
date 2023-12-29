using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BusinessLayer.Concrete;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.EntityFramework;

namespace NotGoruntulemePaneli.Controllers
{
    public class OgrtimUyesiController : Controller
    {
        OgretimUyesiManager OgretimUyesiManager = new OgretimUyesiManager(new EFOgretimUyesiRepository());
        public IActionResult Index()
        {
            var values = OgretimUyesiManager.OgretimUyesiListAll();
            return View(values);
        }
    }
}
