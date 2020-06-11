using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop
{
    static public class DBObjects
    {

        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
                content.Car.AddRange(Cars.Select(c => c.Value));

            content.SaveChanges();

        }

        private static Dictionary<string, Category> _categories;
        private static Dictionary<string, Car> _cars;

        public static Dictionary<string, Car> Cars
        {
            get
            {
                if (_cars == null)
                {
                    var list = new Car[]
                    {
                        new Car { Name = "Tesla Model S",
                              ShortDesc = "Быстрый автомобиль",
                              LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                              Img = "/img/tesla.jpg",
                              Price = 45000,
                              IsFavorite = true,
                              Avalible = true,
                              Category = Categories["Электромобили"]
                                },
                    new Car { Name = "Ford Fiesta",
                              ShortDesc = "Тихий и спокойный",
                              LongDesc = "Удобный автоиобиль для городской жизни",
                              Img = "/img/fiesta.jpg",
                              Price = 11000,
                              IsFavorite = false,
                              Avalible = true,
                              Category = Categories["Классические автомобили"]
                    },
                    new Car { Name = "BMW M3",
                              ShortDesc = "Дерзкий и стильный",
                              LongDesc = "Удобный автомобиль для городской жизни",
                              Img = "/img/bmw.jpg",
                              Price = 65000,
                              IsFavorite = true,
                              Avalible = true,
                              Category = Categories["Классические автомобили"]
                    },
                    new Car { Name = "Mercedes C class",
                              ShortDesc = "Уютный и большой",
                              LongDesc = "Удобный автомобиль для городской жизни",
                              Img = "/img/mercedes.jpg",
                              Price = 40000,
                              IsFavorite = false,
                              Avalible = false,
                              Category = Categories["Классические автомобили"]
                    },
                    new Car { Name = "Nissan Leaf",
                              ShortDesc = "Бесшумный и экономный",
                              LongDesc = "Удобный автомобиль для городской жизни",
                              Img = "/img/nissan.jpg",
                              Price = 14000,
                              IsFavorite = true,
                              Avalible = true,
                              Category = Categories["Электромобили"]
                    }
                    };

                    _cars = new Dictionary<string, Car>();

                    foreach (Car car in list)
                        _cars.Add(car.Name, car);

                }

                return _cars;
            }
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var list = new Category[]
                    {
                        new Category{ CategoryName = "Электромобили", Desc = "Современный вид транспорта"},
                        new Category{ CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания" }
                    };

                    _categories = new Dictionary<string, Category>();

                    foreach (Category el in list)
                        _categories.Add(el.CategoryName, el);
                }

                return _categories;
            }
        }


    }
}
