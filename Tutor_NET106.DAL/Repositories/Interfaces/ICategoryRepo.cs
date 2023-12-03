using Tutor_NET106.DAL.Models;

namespace Tutor_NET106.DAL.Repositories.Interfaces
{
    public interface ICategoryRepo
    {
        Category GetById(Guid idCategory);
        List<Category> GetList();
        bool Add(Category request);
        bool Update(Category request);
        bool Delete(Guid idCategory);
    }
}
