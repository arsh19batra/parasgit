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
    public class WomanApparelPagesModel : PageModel
    {
        private readonly ILogger<WomanApparelPagesModel> _logger;
        public List<Woman> womenProducts;
        private readonly online_storeContext _context;
        public WomanApparelPagesModel(ILogger<WomanApparelPagesModel> logger, online_storeContext context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
            WomanModelClass womanModelClass = new WomanModelClass(_context);
            womenProducts = womanModelClass.GetWomenProducts();
        }
    }
}
