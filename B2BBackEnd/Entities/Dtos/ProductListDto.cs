using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Entities.Dtos
{
    public class ProductListDto:Product
    {
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
       
    }
}
