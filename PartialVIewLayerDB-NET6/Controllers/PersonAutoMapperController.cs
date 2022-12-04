using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PartialViewDB.Services;
using PartialVIewLayerDB_NET6.ViewModels;

namespace PartialVIewLayerDB_NET6.Controllers
{
    public class PersonAutoMapperController : Controller
    {
        private readonly AdultService _adultService;

        private readonly IMapper _mapper;

        public PersonAutoMapperController(IMapper mapper)
        {
            _mapper = mapper;

            _adultService = new AdultService();
        }
        public IActionResult Index()
        {
            var lstAdults = _adultService.GetAll();  // Domain objects
            List<AdultVM>? adultVMs = null;

            if (lstAdults != null)
            {
                adultVMs = _mapper.Map<List<AdultVM>>(lstAdults);
            }

            return View(adultVMs);  // Always VM 
        }
    }
}
