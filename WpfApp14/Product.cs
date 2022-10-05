using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
   public enum ProductCategories
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public string ProdImage { get; set; }   
        public ProductCategories ProductCategory { get; set; }
    }
}
