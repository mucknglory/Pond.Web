using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pond.Web.Areas.Client.Controllers
{
    [Authorize]
    public class ContactsController : Controller
    {
        // GET: Contact
        public ActionResult Contacts()
        {
            return View();
        }
    }
}