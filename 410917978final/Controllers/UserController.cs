using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _410917978final.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(string name, float number)
        {
            return View();
        }
    }
}