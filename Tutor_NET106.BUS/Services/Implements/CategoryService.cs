using Tutor_NET106.BUS.Services.Interfaces;
using Tutor_NET106.DAL.Models;
using Tutor_NET106.DAL.Repositories.Implements;
using Tutor_NET106.DAL.Repositories.Interfaces;

namespace Tutor_NET106.BUS.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepo _categoryRepo; // Khai bao

        public CategoryService()
        {
            _categoryRepo = new CategoryRepo(); // Khoi tao
        }

        public Category GetById(Guid idCategory)
        {
            var obj = _categoryRepo.GetById(idCategory);

            return obj;
        }

        public List<Category> GetList()
        {
            var listObj = _categoryRepo.GetList();

            return listObj;
        }

        public bool Add(Category request)
        {
            return _categoryRepo.Add(request);
        }

        public bool Update(Category request)
        {
            return _categoryRepo.Update(request);
        }

        public bool Delete(Guid idCategory)
        {
            return _categoryRepo.Delete(idCategory);
        }
    }
}
