using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace escale.Controllers
{

    public class ProductController : Controller
    {
       public ActionResult Detail(string id)
{
    using var product = new z_sqlProducts();
    var model = product.GetData(id);
    return View(model);
}



  }
}
