using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHdeleon.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        public ActionResult Index()
        {
            List<SelectListItem> lst = new List<SelectListItem>();

            using (Models.MVCHdeleonEntities db = new Models.MVCHdeleonEntities())
            {
                lst = (from d in db.animal_class
                       select new SelectListItem
                       {
                           Value = d.id.ToString(),
                           Text = d.name
                       }).ToList();
            }
            return View(lst);
        }
    }
}