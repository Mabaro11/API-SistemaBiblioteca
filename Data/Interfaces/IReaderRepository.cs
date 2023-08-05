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
    public interface IReaderRepository
    {
        Task<IEnumerable<Reader>> GetReaders();
        Task<Reader> GetReader(int readerId);
        Task<IEnumerable<Reader>> GetReadersAll();

        Task<Reader> AddReader(Reader reader);
        Task<Reader> UpdateReader(Reader reader);
        Task<Reader> DeleteReader(int readerId);
        Task<int> GetTransactionsByReaderID(int readerID);
        Task<int> GetQuantityReaders();
    }
}
