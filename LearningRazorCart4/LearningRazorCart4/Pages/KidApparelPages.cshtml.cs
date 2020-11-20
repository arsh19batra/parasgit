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
    public class KidApparelPagesModel : PageModel
    {
        private readonly ILogger<KidApparelPagesModel> _logger;
        public List<Kid> kidProducts;
        private readonly online_storeContext _context;
        public KidApparelPagesModel(ILogger<KidApparelPagesModel> logger, online_storeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            KidModelClass manModelClass = new KidModelClass(_context);
            kidProducts = manModelClass.GetKidProducts();
        }
    }
}
