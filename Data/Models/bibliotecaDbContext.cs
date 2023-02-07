using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Models
{
    public partial class bibliotecaDbContext : DbContext
    {
        public bibliotecaDbContext(){}
        public bibliotecaDbContext(DbContextOptions<bibliotecaDbContext> options): base(options) {}


        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=127.0.0.1;Database=dblibrary;Uid=root;Pwd=;", ServerVersion.AutoDetect("Server=localhost;Database=dblibrary;Uid=root;Pwd=;"),
                    options => options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: System.TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null));
            }
        }



    }
}
