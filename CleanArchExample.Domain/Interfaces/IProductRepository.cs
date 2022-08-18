using CleanArchExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchExample.Domain.Interfaces
{
     public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
