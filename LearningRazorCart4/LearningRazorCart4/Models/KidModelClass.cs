using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningRazorCart4.Models
{
    public class KidModelClass
    {
        private readonly online_storeContext _context;
        public KidModelClass(online_storeContext context)
        {
            _context = context;
        }
        public List<Kid> GetKidProducts()
        {
            return _context.Kids.ToList();
        }
    }
}
