using JalkaHoitola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JalkaHoitola.Controllers
{
    public class ProductGroupsController : Controller
    {
        // GET: ProductGroups
        public ActionResult Index()
        {
            JalkahoitolaEntities1 entities = new JalkahoitolaEntities1();
            List<ProductGroups> model = entities.ProductGroups.ToList();
            entities.Dispose();

            return View(model);
         }
        //
          public ActionResult Products()
          {
              JalkahoitolaEntities1 entities = new JalkahoitolaEntities1();
              List<Products> model1 = entities.Products.ToList();
              entities.Dispose();

              return View(model1);
    }
}
}