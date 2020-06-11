using shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Interfaces
{
    public interface IAllCars
    {

        IEnumerable<Car> Cars { get; }
        
        IEnumerable<Car> GetFavCars { get; }

        Car getObjectCar (int carId);

    }
}
