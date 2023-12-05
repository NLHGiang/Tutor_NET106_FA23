using Tutor_NET106.BUS.Services.Interfaces;
using Tutor_NET106.DAL.Models;
using Tutor_NET106.DAL.Repositories.Implements;
using Tutor_NET106.DAL.Repositories.Interfaces;

namespace Tutor_NET106.BUS.Services.Implements
{
    public class ProductService : IProductService
    {
        IProductRepo _productRepo; // Khai bao

        public ProductService()
        {
            _productRepo = new ProductRepo(); // Khoi tao
        }

        public Product GetById(Guid idProduct)
        {
            var obj = _productRepo.GetById(idProduct);

            return obj;
        }

        public List<Product> GetList()
        {
            var listObj = _productRepo.GetList();

            return listObj;
        }

        public bool Add(Product request)
        {
            return _productRepo.Add(request);
        }

        public bool Update(Product request)
        {
            return _productRepo.Update(request);
        }

        public bool Delete(Guid idProduct)
        {
            return _productRepo.Delete(idProduct);
        }
    }
}
