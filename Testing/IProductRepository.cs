using System.Collections.Generic;
using Testing.Models;
using System;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
