using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly DBContext _context;

        public SellerService(DBContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.sellers.ToList();
        }
        public void Insert(Seller obj)
        {
            obj.departaments = _context.Departaments.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
