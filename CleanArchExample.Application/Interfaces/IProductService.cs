using CleanArchExample.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchExample.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetProducts();

        Task<ProductViewModel> GetById(int? id);

        void Add(ProductViewModel product);

        void Update(ProductViewModel product);

        void Delete(int? id);
    }
}
