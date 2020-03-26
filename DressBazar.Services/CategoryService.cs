using DressBazar.Database;
using DressBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressBazar.Services
{
    public class CategoryService
    {
        public void SaveCategory(Category category)
        {
            using (var context =new DBazarContext())
            {
                context.categories.Add(category);
                context.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new DBazarContext())
            {
                return context.categories.ToList();
            }
        }

        public Category GetCategory(int ID)
        {
            using (DBazarContext context = new DBazarContext())
            {
                return context.categories.Find(ID);
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new DBazarContext())
            {
                // context.Entry(category).State = System.Data.Entity.EntityState.Modified;

                context.categories.Remove(category);
                context.SaveChanges();
            }
        }
        public void DeleteCategory(Category category)
        {
            using (var context = new DBazarContext())
            {
                // context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                category = context.categories.Find(category.ID);
                context.categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
