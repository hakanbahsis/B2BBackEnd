using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Entities.Dtos
{
    public class BasketListDto:Basket
    {
        public string ProductName { get; set; }
        public decimal Total { get; set; }
    }
}
