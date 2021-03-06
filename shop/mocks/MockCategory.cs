﻿using shop.Interfaces;
using shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryName = "Электромобили", Desc = "Современный вид транспорта"},
                    new Category{ CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}
