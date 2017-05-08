using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Raet.Recruitment.Desing.ChatService.MvcUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
