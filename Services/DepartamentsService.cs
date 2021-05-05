using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DepartamentsService
    {
        private readonly DBContext _context;

        public DepartamentsService(DBContext context)
        {
            _context = context;
        }
        public List<Departaments> FindAll()
        {
            return _context.Departaments.OrderBy(x => x.Nome).ToList();
        }
    }
}
