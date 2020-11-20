using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningRazorCart4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LearningRazorCart4.Pages
{
    public class ManApparelPagesModel : PageModel
    {
        private readonly ILogger<ManApparelPagesModel> _logger;
        public List<Man> menProducts;
        private readonly online_storeContext _context;
        public ManApparelPagesModel(ILogger<ManApparelPagesModel> logger, online_storeContext context)
        {
             _logger = logger;
             _context = context;
        }

        public void OnGet()
        {
            ManModelClass manModelClass = new ManModelClass(_context);
            menProducts = manModelClass.GetMenProducts();
        }
    }
}
