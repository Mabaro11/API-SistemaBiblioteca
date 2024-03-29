﻿using Data.Interfaces;
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

        /** 
            * Este metodo no elimina verdaderamente el registro ya que
            * si se eliminan las categorias se pierden las relaciones. 
            * Lo que se hace es dar de baja la categoria.
        */
        public async Task<Book> DeleteBook(int bookId)
        {
            var result = await bibliotecaDbContext.Books
                 .FirstOrDefaultAsync(e => e.ID == bookId);
            if (result != null)
            {
                result.Lower = true;
                bibliotecaDbContext.Update(result);
                //bibliotecaDbContext.Books.Remove(result);
                await bibliotecaDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Book> GetBook(int bookId)
        {
            return await bibliotecaDbContext.Books
                .FirstOrDefaultAsync(e => e.ID == bookId && e.Lower == false);
        }

        /*
         Esta funcion se utiliza al traer las transacciones en Desktop ya que sino arroja una exepcion.
         */
        public async Task<IEnumerable<Book>> GetBooksAll()
        {
            return await bibliotecaDbContext.Books.ToListAsync();

        }

        public async Task<int> GetQuantityBooks()
        {
            return await bibliotecaDbContext.Books.Where(e => e.Lower == false).CountAsync();
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            
            //return await bibliotecaDbContext.Books.Include(b => b.Category).ToListAsync() as IEnumerable<Book>;
            return await bibliotecaDbContext.Books.Where(e => e.Lower == false).ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksCategory(int categoryId)
        {
            return await bibliotecaDbContext.Books.Where(x => x.CategoryID == categoryId ).ToListAsync();
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
