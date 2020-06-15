using Microsoft.AspNetCore.Mvc;
using shop.Interfaces;
using shop.Models;
using shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class CarsController : Controller
    {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
            {
                cars = _allCars.Cars.Where(c => c.Category.CategoryName.Equals("Электромобили")).OrderBy(c => c.Id);
                currCategory = "Электромобили";
            }
            else if(string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
            {
                cars = _allCars.Cars.Where(c => c.Category.CategoryName.Equals("Классические автомобили")).OrderBy(c => c.Id);
                currCategory = "Классические автомобили";

            }


            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                CurrCategory = currCategory
            };


            ViewBag.Title = "Страница с автомобилями";
            return View(carObj);

        }

    }
}
