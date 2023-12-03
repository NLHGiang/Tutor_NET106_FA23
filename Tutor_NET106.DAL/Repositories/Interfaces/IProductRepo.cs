using Tutor_NET106.DAL.Models;

namespace Tutor_NET106.DAL.Repositories.Interfaces
{
    public interface IProductRepo
    {
        Product GetById(Guid idProduct);
        List<Product> GetList();
        bool Add(Product request);
        bool Update(Product request);
        bool Delete(Guid idProduct);
    }
}
