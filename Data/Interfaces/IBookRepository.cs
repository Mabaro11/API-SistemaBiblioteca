using Data.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<IEnumerable<Book>> GetBooksAll();
        Task<IEnumerable<Book>> GetBooksCategory(int categoryId);
        Task<Book> GetBook(int bookId);
        Task<Book> AddBook(Book book);
        Task<Book> UpdateBook(Book book);
        Task<Book> DeleteBook(int bookId);
        Task<int> GetQuantityBooks();
    }
}
