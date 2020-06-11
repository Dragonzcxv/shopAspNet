using Microsoft.EntityFrameworkCore;
using shop.Interfaces;
using shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Repository
{
    public class CarRepository : IAllCars
    {

        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(c => c.IsFavorite).Include(c => c.Category);

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(c => c.Id == carId);
    }
}
