using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    // Для работы приложения с базой данной через Entity Framework необходим контекст данных - класс производный от DbContext.
    // В данном случае таким контекстом является класс AppDbContext
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        // В классе определено свойство Books and Authors, которое будет хранить набор объектов Book and Author
        public DbSet<Book> Books => Set<Book>(); 
        public DbSet<Author> Authors => Set<Author>();
        // По умолчанию у нас нет базы данных. Поэтому в конструкторе класса контекста определен вызов метода Database.EnsureCreated(),
        // который при создании контекста автоматически проверит наличие базы данных и, если она отсуствует, создаст ее.
        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=booksdb.db");
        }
    }
}
