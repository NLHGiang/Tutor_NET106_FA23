using Tutor_NET106.DAL.ApplicationDbContext;
using Tutor_NET106.DAL.Models;
using Tutor_NET106.DAL.Repositories.Interfaces;

namespace Tutor_NET106.DAL.Repositories.Implements
{
    public class ProductRepo : IProductRepo
    {
        AppDbContext _dbContext; // Khai bao AppDbContext

        public ProductRepo()
        {
            _dbContext = new(); // Khoi tao AppDbContext = new()
        }

        public Product GetById(Guid idProduct)
        {
            var obj = _dbContext.Products.FirstOrDefault(o => o.Id == idProduct);

            return obj;
        }

        public List<Product> GetList()
        {
            var listObj = _dbContext.Products.ToList();

            return listObj;
        }

        public bool Add(Product request)
        {
            try
            {
                _dbContext.Products.Add(request);
                _dbContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Product request)
        {
            try
            {
                // Check existed
                var existedObj = _dbContext.Products.FirstOrDefault(o => o.Id == request.Id);

                // Check if existed Obj with Id = request.Id in database 
                if (existedObj == null)
                {
                    return false;
                }
                else
                {
                    // Change value
                    existedObj.ProductName = request.ProductName;
                    existedObj.Price = request.Price;
                    existedObj.Amount = request.Amount;

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

        public bool Delete(Guid idProduct)
        {
            try
            {
                // Check existed
                var existedObj = _dbContext.Products.FirstOrDefault(o => o.Id == idProduct);

                // Check if existed Obj with Id = idProduct in database
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
