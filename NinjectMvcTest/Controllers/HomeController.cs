using NinjectMvcTest.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjectMvcTest.Controllers
{
    public class HomeController : Controller
    {
        private IMessageService _messageService = null;

        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _messageService.GetMessage();
            return View();
        }
    }
}