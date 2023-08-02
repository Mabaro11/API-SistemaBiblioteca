using Data.Interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly bibliotecaDbContext bibliotecaDbContext;
        internal DbSet<Category> dbSet;

        public CategoryRepository()
        {
            bibliotecaDbContext = new bibliotecaDbContext();
            this.dbSet = bibliotecaDbContext.Set<Category>();
        }

        public async Task<Category> AddCategory(Category category)
        {
            var result = await bibliotecaDbContext.Categories.AddAsync(category);
            await bibliotecaDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Category> DeleteCategory(int categoryId)
        {

            /** 
             * Este metodo no elimina verdaderamente el registro ya que
             * si se eliminan las categorias se pierden las relaciones. 
             * Lo que se hace es dar de baja la categoria.
            */
            var result = await bibliotecaDbContext.Categories
                 .FirstOrDefaultAsync(e => e.ID == categoryId);
            if (result != null)
            {
                result.Lower = true;
                bibliotecaDbContext.Update(result);
                //bibliotecaDbContext.Categories.Remove(result);
                await bibliotecaDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await bibliotecaDbContext.Categories.ToListAsync() as IEnumerable<Category>;
        }

        public async Task<Category> GetCategory(int categoryId)
        {
            return await bibliotecaDbContext.Categories
                .FirstOrDefaultAsync(e => e.ID == categoryId);
        }

        public async Task<Category> UpdateCategory(Category category) 
        { 
   
            var result = await bibliotecaDbContext.Categories.FirstOrDefaultAsync(e => e.ID == category.ID);

            if (result != null)
            {
                result.Name = category.Name;

                await bibliotecaDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

    }
}
