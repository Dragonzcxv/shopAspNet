using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }

        public Car Car { get; set; }

        public int price { get; set; }

        public string ShopCarId { get; set; }

    }
}
