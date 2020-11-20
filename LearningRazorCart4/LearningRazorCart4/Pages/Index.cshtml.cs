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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly online_storeContext _context;
        public List<Man> menProducts;
        public IndexModel(ILogger<IndexModel> logger, online_storeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
        }
    }
}
