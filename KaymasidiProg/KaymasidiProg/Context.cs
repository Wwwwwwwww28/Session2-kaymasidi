using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaymasidiProg
{
    public partial class user13Entities : DbContext
    {
        private static user13Entities _context;
        public static user13Entities getContext()
        {
            if (_context == null)
            {
                _context = new user13Entities();
            }
            return _context;
        }

    }
}
