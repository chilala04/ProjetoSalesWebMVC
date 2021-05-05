using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate  { get; set; }
        public double BaseSalary { get; set; }
        public Departaments departaments { get; set; }
        public int DepartamentsId { get; set; }
        public ICollection<SellerRecord> sales { get; set; } = new List<SellerRecord>();

        public Seller()
        {

        }

        public Seller(int id, string nome, string email, DateTime birthDate, double baseSalary, Departaments departaments)
        {
            Id = id;
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            this.departaments = departaments;
        }

        public void AddSales(SellerRecord sr)
        {
            sales.Add(sr);
        }
        public void RemoveSales(SellerRecord sr)
        {
            sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
