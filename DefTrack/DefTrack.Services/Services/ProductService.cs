using DataAccess.Repositories.Products;
using DefTrack.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefTrack.Services.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductsRepository _productsRepository;
        public ProductService(IProductsRepository productRepository)
        {
            _productsRepository = productRepository;
        }
        public IList<Domain.Entities.Product> Get()
        {
            return _productsRepository.Get().ToList();
        }

        public Domain.Entities.Product GetProduct(int id)
        {
            return _productsRepository.Find(x => x.Id == id).FirstOrDefault();
        }

        public void Add(Domain.Entities.Product product)
        {
            _productsRepository.Add(product);
            _productsRepository.SaveChanges();
        }

        public void Edit(Domain.Entities.Product product)
        {
            _productsRepository.Update(product);
            _productsRepository.SaveChanges();
        }

        public void remove(Domain.Entities.Product prodcut)
        {
            _productsRepository.Remove(prodcut);
            _productsRepository.SaveChanges();
        }
    }
}
