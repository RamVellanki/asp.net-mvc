using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefTrack.Services.Contracts
{
    public interface IProductService
    {
        IList<Product> Get();
        Product GetProduct(int id);
        void Add(Product product);
        void Edit(Product product);
        void remove(Product prodcut);
    }
}
