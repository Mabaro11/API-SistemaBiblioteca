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
    public class ReaderRepository : IReaderRepository
    {
        private readonly bibliotecaDbContext bibliotecaDbContext;
        internal DbSet<Reader> dbSet;

        public ReaderRepository()
        {
            bibliotecaDbContext = new bibliotecaDbContext();
            this.dbSet = bibliotecaDbContext.Set<Reader>();
        }

        public async Task<Reader> AddReader(Reader reader)
        {
            var result = await bibliotecaDbContext.Readers.AddAsync(reader);
            await bibliotecaDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Reader> DeleteReader(int readerId)
        {
            var result = await bibliotecaDbContext.Readers
                 .FirstOrDefaultAsync(e => e.ID == readerId);
            if (result != null)
            {
                bibliotecaDbContext.Readers.Remove(result);
                await bibliotecaDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Reader> GetReader(int readerId)
        {
            return await bibliotecaDbContext.Readers
                .FirstOrDefaultAsync(e => e.ID == readerId);
        }

        public async Task<IEnumerable<Reader>> GetReaders()
        {
            return await bibliotecaDbContext.Readers.ToListAsync() as IEnumerable<Reader>;
        }

        public async Task<Reader> UpdateReader(Reader reader) 
        { 
   
            var result = await bibliotecaDbContext.Readers.FirstOrDefaultAsync(e => e.ID == reader.ID);

            if (result != null)
            {
                result.Name = reader.Name;
                result.Email = reader.  Email;
                result.DNI = reader.DNI;
                result.Address = reader.Address;
                result.Phone = reader.Phone;

                await bibliotecaDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
