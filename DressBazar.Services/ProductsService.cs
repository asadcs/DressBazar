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
        public Product GetProductsbyID(int ID)
        {
            using (var context = new DressBazar.Database.DBazarContext())
            {
                return context.products.Find(ID);
            }
        }
        public void UpdateProduct(Product product)
        {
            using (var context = new DressBazar.Database.DBazarContext())
            {
                 context.Entry(product).State = System.Data.Entity.EntityState.Modified;

               // context.categories.Remove(product);
                context.SaveChanges();
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
        public void DeleteProduct(int id)
        {
            using (var context = new DressBazar.Database.DBazarContext())
            {
                // context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                var product = context.products.Find(id);
                context.products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
