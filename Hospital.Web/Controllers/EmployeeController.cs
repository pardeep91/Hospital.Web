using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital.DTO;
using Hospital.Services.Iservices;
using Hospital.Services.Services;

namespace Hospital.Web.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IemployeeServices _employeeServices;

        public EmployeeController()
        {
            _employeeServices = new employeeServices();
        }
        [Authorize]
        // GET: Employee
        public ActionResult Index()
        {
            return View(_employeeServices.GetEmployee());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeDTO empdto)
        {
            _employeeServices.Create(empdto);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var data = _employeeServices.GetById(id);
            return View(data);
        }
        [HttpPost][ActionName("Delete")]
        public ActionResult DeleteConfirm ( int id)
        {
            _employeeServices.Delete(id);
            return RedirectToAction("Index");

        }
    }
}