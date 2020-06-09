using shop.Interfaces;
using shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { Name = "Tesla Model S",
                              ShortDesc = "Быстрый автомобиль", 
                              LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                              Img = "https://img.drive.ru/i/0/5ea6dd8dec05c41134000004.jpg",
                              Price = 45000,
                              IsFavorite = true,
                              Avalible = true,
                              Category = _categoryCars.AllCategories.First()
                    },
                    new Car { Name = "Ford Fiesta",
                              ShortDesc = "Тихий и спокойный",
                              LongDesc = "Удобный автоиобиль для городской жизни",
                              Img = "https://auto.ironhorse.ru/wp-content/uploads/2017/02/Fiesta-ST-2.jpg",
                              Price = 11000,
                              IsFavorite = false,
                              Avalible = true,
                              Category = _categoryCars.AllCategories.Last()
                    },
                    new Car { Name = "BMW M3",
                              ShortDesc = "Дерзкий и стильный",
                              LongDesc = "Удобный автомобиль для городской жизни",
                              Img = "https://wroom.ru/i/cars2/bmw_m3_5.jpg",
                              Price = 65000,
                              IsFavorite = true,
                              Avalible = true,
                              Category = _categoryCars.AllCategories.Last()
                    },
                    new Car { Name = "Mercedes C class",
                              ShortDesc = "Уютный и большой",
                              LongDesc = "Удобный автомобиль для городской жизни",
                              Img = "https://sales.mercedes-wagner.ru/images/cms/model_gallery/c_class_sedan/18c0838_281.jpg",
                              Price = 40000,
                              IsFavorite = false,
                              Avalible = false,
                              Category = _categoryCars.AllCategories.Last()
                    },
                    new Car { Name = "Nissan Leaf",
                              ShortDesc = "Бесшумный и экономный",
                              LongDesc = "Удобный автомобиль для городской жизни",
                              Img = "https://electromobili.ru/images/com_hikashop/upload/nissan-leaf-azeo.jpg",
                              Price = 14000,
                              IsFavorite = true,
                              Avalible = true,
                              Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
