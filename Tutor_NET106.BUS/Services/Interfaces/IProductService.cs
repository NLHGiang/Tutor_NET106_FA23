using Tutor_NET106.DAL.Models;

namespace Tutor_NET106.BUS.Services.Interfaces
{
    public interface IProductService
    {
        Product GetById(Guid idProduct);
        List<Product> GetList();
        bool Add(Product request);
        bool Update(Product request);
        bool Delete(Guid idProduct);
    }
}
