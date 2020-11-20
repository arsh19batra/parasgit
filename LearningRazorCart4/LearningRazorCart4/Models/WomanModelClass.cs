using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningRazorCart4.Models
{
    public class WomanModelClass
    {
        private readonly online_storeContext _context;
        public WomanModelClass(online_storeContext context)
        {
            _context = context;
        }
        public List<Woman> GetWomenProducts()
        {
            return _context.Women.ToList();
        }
    }
}
