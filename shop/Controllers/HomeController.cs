using Microsoft.AspNetCore.Mvc;
using shop.Interfaces;
using shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class HomeController : Controller
    {

        private IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {

            var homeCars = new HomeViewModel
            {
                FavCars = _carRep.GetFavCars
            };

            return View(homeCars);

        }

    }
}
