﻿using shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Interfaces
{
    public interface IAllOrders
    {

        void CreateOrder(Order order);

    }
}
