using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningRazorCart.Models
{
    public class ProductModel
    {
        private readonly online_storeContext _context;

        

        public ProductModel(online_storeContext context)
        {
            _context = context;
        }
        public List<Product> GetAllDetails()
        {
            return _context.Products.ToList();
        }
        public Product GetDetailById(int id)
        {
            return _context.Products.FirstOrDefault(p=> p.ProductId==id);
        }
    }
}
