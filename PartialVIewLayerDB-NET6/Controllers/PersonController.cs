using Microsoft.AspNetCore.Mvc;
using PartialViewDB.Services;
using PartialVIewLayerDB_NET6.ViewModels;

namespace PartialVIewLayerDB_NET6.Controllers
{
    public class PersonController : Controller
    {
        private readonly AdultService _adultService;

        public PersonController()
        {// Later with DI
            _adultService = new AdultService();
        }
        public IActionResult Index()
        {
            var lstAdults = _adultService.GetAll();  // Domain objects
            List<AdultVM> adultVMs = new List<AdultVM>();

            if (lstAdults != null)
            {
                foreach (var adult in lstAdults)
                {
                    var adultVM = new AdultVM();
                    // later we use an automapper
                    adultVM.FirstName = adult.FirstName;
                    adultVM.LastName = adult.LastName;
                    adultVM.EnrollDate = adult.EnrollDate;
                    adultVMs.Add(adultVM);
                }
            }

            return View(adultVMs);  // Always VM 
        }
    }
}
