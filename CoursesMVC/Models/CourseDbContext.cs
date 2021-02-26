using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesMVC.Models
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            // One -to -Many
             mb.Entity<Book>()
                 .HasOne<Publisher>(b => b.Publisher)
                 .WithMany(p => p.Books)
                 .HasForeignKey(b => b.PublisherId);


            mb.Entity<AuthorBook>()
                .HasKey(ab => new { ab.BookId, ab.AuthorId });

            mb.Entity<AuthorBook>()
                .HasOne<Book>(ab => ab.Book)
                .WithMany(b => b.AurhorBooks)
                .HasForeignKey(ab => ab.BookId);

             mb.Entity<AuthorBook>()
                .HasOne<Author>(ab => ab.Author)
                .WithMany(a => a.AurhorBooks)
                .HasForeignKey(ab => ab.AuthorId);    
            
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<AuthorBook> AuthorBooks { get; set; }

       // public DbSet<PublisherBook> PublisherBooks { get; set; }

    }
}
