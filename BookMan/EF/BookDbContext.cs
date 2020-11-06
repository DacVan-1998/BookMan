using BookMan.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMan.EF
{
    public class BookDbContext : DbContext
    {
        public const string con_str = @"Data Source=DESKTOP-TC51ULG\SQLEXPRESS;Initial Catalog=Book;User ID=SA;Password=anhvan123";

        public BookDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(con_str);           // thiết lập làm việc với SqlServer

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
              new Book() { Id = 1, Name = "ASP.NET Core for dummy", Authors = "Trump D.", Publisher = "Washington", Year = 2020, Description = "Đây là của Trump" },
              new Book() { Id = 2, Name = "Pro ASP.NET Core", Authors = "Putin V. D.", Publisher = "Moscow", Year = 2020, Description = "Đây là của Putin" },
              new Book() { Id = 3, Name = "ASP.NET Core Video Tutorial  ", Authors = "Obama B.", Publisher = "Washington", Year = 2020, Description = "Đây là của Obama" }
              );
        }
    }

}
