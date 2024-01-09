using VoucherTrackerApp.DAL.Interface;
using VoucherTrackerApp.DAL.Repository;
using VoucherTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace VoucherTrackerApp.Controllers
{
    public class VoucherTrackerController : Controller
    {
        private readonly IVoucherTrackerInterface _Repository;
        public VoucherTrackerController(IVoucherTrackerInterface service)
        {
            _Repository = service;
        }
        public VoucherTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: VoucherTracker
        public ActionResult Index()
        {
            var vouchers = from work in _Repository.GetVouchers()
                        select work;
            return View(vouchers);
        }

        public ViewResult Details(int id)
        {
            Voucher voucher =   _Repository.GetVoucherByID(id);
            return View(voucher);
        }

        public ActionResult Create()
        {
            return View(new Voucher());
        }

        [HttpPost]
        public ActionResult Create(Voucher voucher)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.InsertVoucher(voucher);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(voucher);
        }

        public ActionResult EditAsync(int id)
        {
            Voucher voucher =  _Repository.GetVoucherByID(id);
            return View(voucher);
        }
        [HttpPost]
        public ActionResult Edit(Voucher voucher)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.UpdateVoucher(voucher);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(voucher);
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }
            Voucher voucher =  _Repository.GetVoucherByID(id);
            return View(voucher);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Voucher voucher =  _Repository.GetVoucherByID(id);
                _Repository.DeleteVoucher(id);
                _Repository.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete",
                   new System.Web.Routing.RouteValueDictionary {
        { "id", id },
        { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }
    }
}