﻿using shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.ViewModels
{
    public class CarsListViewModel
    {

        public IEnumerable<Car> AllCars { get; set; }

        public string CurrCategory { get; set; }

    }
}
