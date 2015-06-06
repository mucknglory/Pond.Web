using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pond.Web.Areas.Client.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Search()
        {
            return View();
        }

        // GET: SearchResults
        public ActionResult SearchResults()
        {
            return View();
        }

        // GET: ShowAvailability
        public ActionResult ProviderAvailability()
        {
            return View();
        }
    }
}