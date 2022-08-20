using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchExample.Application.ViewModels;

namespace CleanArchExample.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetProducts();

        Task<ProductViewModel> GetById(int? id);

        void Add(ProductViewModel product);
        void Update(ProductViewModel product);
        void Remove(int? id);
    }
}