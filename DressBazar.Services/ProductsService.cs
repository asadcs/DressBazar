using DressBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressBazar.Services
{
    public class ProductsService
    {
        public List<Product> GetProducts()
        {
            using (var context = new DressBazar.Database.DBazarContext())
            {
                return context.products.ToList();
            }
        }
        public void SaveProducts(Product product)
        {
            using (var context = new DressBazar.Database.DBazarContext())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
