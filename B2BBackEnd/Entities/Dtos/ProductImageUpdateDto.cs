using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Entities.Dtos
{
    public class ProductImageUpdateDto:ProductImage
    {
        public IFormFile Image { get; set; }
    }
}
