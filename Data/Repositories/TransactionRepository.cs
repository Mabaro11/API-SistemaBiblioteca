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
    public class TransactionRepository : ITransactionRepository
    {
        private readonly bibliotecaDbContext bibliotecaDbContext;
        internal DbSet<Book> dbSet;

        public TransactionRepository()
        {
            bibliotecaDbContext = new bibliotecaDbContext();
            this.dbSet = bibliotecaDbContext.Set<Book>();
        }

        public async Task<Transaction> AddTransaction(Transaction transaction)
        {
            var result = await bibliotecaDbContext.Transactions.AddAsync(transaction);
            await bibliotecaDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Transaction> DeleteTransaction(int transactionId)
        {
            var result = await bibliotecaDbContext.Transactions
                 .FirstOrDefaultAsync(e => e.ID == transactionId);
            if (result != null)
            {
                bibliotecaDbContext.Transactions.Remove(result);
                await bibliotecaDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Transaction> GetTransaction(int transactionId)
        {
            return await bibliotecaDbContext.Transactions
                .FirstOrDefaultAsync(e => e.ID == transactionId);
        }

        public async Task<IEnumerable<Transaction>> GetTransactions()
        {
            return await bibliotecaDbContext.Transactions.ToListAsync() as IEnumerable<Transaction>;
        }

        public async Task<Transaction> UpdateTransaction(Transaction transaction) 
        { 
   
            var result = await bibliotecaDbContext.Transactions.FirstOrDefaultAsync(e => e.ID == transaction.ID);

            if (result != null)
            {
                result.LoanDate = transaction.LoanDate;
                result.ReturnDate = transaction.ReturnDate;
                result.ReaderID = transaction.ReaderID;
                result.BookID = transaction.BookID;

                await bibliotecaDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
