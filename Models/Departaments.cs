using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Departaments
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Seller> sellers { get; set; } = new List<Seller>();

        public Departaments()
        {

        }

        public Departaments(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddSeller(Seller seller)
        {
            sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
