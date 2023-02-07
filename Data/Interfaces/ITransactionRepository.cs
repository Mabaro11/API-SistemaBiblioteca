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
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetTransactions();
        Task<Transaction> GetTransaction(int transactionId);
        Task<Transaction> AddTransaction(Transaction transaction);
        Task<Transaction> UpdateTransaction(Transaction transaction);
        Task<Transaction> DeleteTransaction(int transactionId);
    }
}
