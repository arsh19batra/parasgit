using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningRazorCart4.Models
{
    public class ManModelClass
    {
        
        private readonly online_storeContext _context;
        public ManModelClass(online_storeContext context)
        {
            _context = context;
        }
        public List<Man> GetMenProducts()
        {
            return _context.Men.ToList();
        }

    }
}
