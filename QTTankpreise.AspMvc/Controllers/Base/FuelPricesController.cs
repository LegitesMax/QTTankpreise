using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QTTankpreise.AspMvc.Models.Base;
using QTTankpreise.Logic.Contracts.Base;

namespace QTTankpreise.AspMvc.Controllers.Base
{

    public class FuelPricesController : Controller
    {

        private readonly Logic.Contracts.Base.IFuelPricesAccess fuelPricesAccess;
        public FuelPricesController(IFuelPricesAccess fuelPricesAccess)
        {
            this.fuelPricesAccess = fuelPricesAccess;
        }

        // GET: FuelPricesController
        public ActionResult Index()
        {
            var models = new List<FuelPrice>();

            return View(models);
        }

        public ActionResult Filter(string location, string distance, string fuel)
        {
            ViewBag.Stadt = location;
            var models = new List<FuelPrice>();
            using var ctrl = new Logic.Controllers.Base.FuelPricesController();

            var entities = ctrl.GetFuelPrices(location, distance, fuel).ToList();
            models = entities.Select(e => Models.Base.FuelPrice.Create(e)).ToList();

            return View("Index", models);
        }

        // GET: FuelPricesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FuelPricesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuelPricesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FuelPricesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FuelPricesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FuelPricesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FuelPricesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
