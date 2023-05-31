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
    public class BookRepository : IBookRepository
    {
        private readonly bibliotecaDbContext bibliotecaDbContext;
        internal DbSet<Book> dbSet;

        public BookRepository()
        {
            bibliotecaDbContext = new bibliotecaDbContext();
            this.dbSet = bibliotecaDbContext.Set<Book>();
        }

        public async Task<Book> AddBook(Book book)
        {
            var result = await bibliotecaDbContext.Books.AddAsync(book);
            await bibliotecaDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Book> DeleteBook(int bookId)
        {
            var result = await bibliotecaDbContext.Books
                 .FirstOrDefaultAsync(e => e.ID == bookId);
            if (result != null)
            {
                bibliotecaDbContext.Books.Remove(result);
                await bibliotecaDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Book> GetBook(int bookId)
        {
            return await bibliotecaDbContext.Books
                .FirstOrDefaultAsync(e => e.ID == bookId);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            
            //return await bibliotecaDbContext.Books.Include(b => b.Category).ToListAsync() as IEnumerable<Book>;
            return await bibliotecaDbContext.Books.ToListAsync() as IEnumerable<Book>;
        }

        public async Task<Book> UpdateBook(Book book) 
        { 
   
            var result = await bibliotecaDbContext.Books.FirstOrDefaultAsync(e => e.ID == book.ID);

            if (result != null)
            {
                result.Title = book.Title;
                result.Description = book.Description;
                result.Author = book.Author;
                result.Editorial = book.Editorial;
                result.CategoryID = book.CategoryID;

                await bibliotecaDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
