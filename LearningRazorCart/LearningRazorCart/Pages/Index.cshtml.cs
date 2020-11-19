using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningRazorCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningRazorCart.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;
        private readonly online_storeContext _context;
        public IndexModel(online_storeContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            ProductModel productModel = new ProductModel(_context);
            Products = productModel.GetAllDetails();
        }
    }
}
