using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    // Для работы приложения с базой данной через Entity Framework необходим контекст данных - класс производный от DbContext.
    // В данном случае таким контекстом является класс AppDbContext
    public class AppDbContext : DbContext 
    {
        // В классе определено свойство Books and Authors, которое будет хранить набор объектов Book and Author
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book { Author = "jhdk", BookCategory = Enums.BookCategory.Comedy, BookId = 1, Description = "jhh", Title = "Hjh"}
                );

        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=booksdb.db");
        }
    }
}
