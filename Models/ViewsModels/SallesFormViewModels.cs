using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models.ViewsModels
{
    public class SallesFormViewModels
    {
        public Seller seller { get; set; }
        public ICollection<Departaments> Departaments { get; set; }
    }
}
