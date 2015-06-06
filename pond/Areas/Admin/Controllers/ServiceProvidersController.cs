using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pond.Web.Areas.Admin.Models;
using Pond.Web.Models;

namespace Pond.Web.Areas.Admin.Controllers
{
    [RoutePrefix("admin")]
    public class ServiceProvidersController : Controller
    {
        private PondWebContext db = new PondWebContext();

        // GET: /Admin/ServiceProviders/
        public async Task<ActionResult> Index()
        {
            return View(await db.ServiceProviders.ToListAsync());
        }

        // GET: /Admin/ServiceProviders/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvider serviceProvider = await db.ServiceProviders.FindAsync(id);
            if (serviceProvider == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvider);
        }

        // GET: /Admin/ServiceProviders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Admin/ServiceProviders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include="ServiceProviderId,Name,Description,Telephone1,Telephone1Type,Telephone2,Telephone2Type,URL,Rating")] ServiceProvider serviceProvider)
        {
            if (ModelState.IsValid)
            {
                db.ServiceProviders.Add(serviceProvider);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(serviceProvider);
        }

        // GET: /Admin/ServiceProviders/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvider serviceProvider = await db.ServiceProviders.FindAsync(id);
            if (serviceProvider == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvider);
        }

        // POST: /Admin/ServiceProviders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include="ServiceProviderId,Name,Description,Telephone1,Telephone1Type,Telephone2,Telephone2Type,URL,Rating")] ServiceProvider serviceProvider)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceProvider).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(serviceProvider);
        }

        // GET: /Admin/ServiceProviders/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceProvider serviceProvider = await db.ServiceProviders.FindAsync(id);
            if (serviceProvider == null)
            {
                return HttpNotFound();
            }
            return View(serviceProvider);
        }

        // POST: /Admin/ServiceProviders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            ServiceProvider serviceProvider = await db.ServiceProviders.FindAsync(id);
            db.ServiceProviders.Remove(serviceProvider);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
