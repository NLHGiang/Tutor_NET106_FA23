using Tutor_NET106.DAL.ApplicationDbContext;
using Tutor_NET106.DAL.Models;
using Tutor_NET106.DAL.Repositories.Interfaces;

namespace Tutor_NET106.DAL.Repositories.Implements
{
    public class CategoryRepo : ICategoryRepo
    {
        AppDbContext _dbContext; // Khai bao AppDbContext

        public CategoryRepo()
        {
            _dbContext = new(); // Khoi tao AppDbContext = new()
        }

        public Category GetById(Guid idCategory)
        {
            var obj = _dbContext.Categories.FirstOrDefault(o => o.Id == idCategory);

            return obj;
        }

        public List<Category> GetList()
        {
            var listObj = _dbContext.Categories.ToList();

            return listObj;
        }

        public bool Add(Category request)
        {
            try
            {
                _dbContext.Categories.Add(request);
                _dbContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Category request)
        {
            try
            {
                // Check existed
                var existedObj = _dbContext.Categories.FirstOrDefault(o => o.Id == request.Id);

                // Check if existed Obj with Id = request.Id in database 
                if (existedObj == null)
                {
                    return false;
                }
                else
                {
                    // Change value
                    existedObj.Name = request.Name;

                    // Update
                    _dbContext.Update(existedObj);
                    _dbContext.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid idCategory)
        {
            try
            {
                // Check existed
                var existedObj = _dbContext.Categories.FirstOrDefault(o => o.Id == idCategory);

                // Check if existed Obj with Id = idCategory in database 
                if (existedObj == null)
                {
                    return false;
                }
                else
                {
                    // Delete
                    _dbContext.Remove(existedObj);
                    _dbContext.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
