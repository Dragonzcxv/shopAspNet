using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace shop.Models
{
    public class Category
    {

        public int Id { get; set; }
        
        public string CategoryName { get; set; }

        public string Desc { get; set; }

        public List<Car> Cars { get; set; }
            
    }
}
