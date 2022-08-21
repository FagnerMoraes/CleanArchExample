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
        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetById(int? id);

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
