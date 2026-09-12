using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Press> Presses { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Lib> Libs { get; set; }
    public DbSet<S_Card> S_Cards { get; set; }
    public DbSet<T_Card> T_Cards { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne(x => x.Theme)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.Id_Themes);

        modelBuilder.Entity<Book>()
            .HasOne(x => x.Category)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.Id_Category);

        modelBuilder.Entity<Book>()
            .HasOne(x => x.Author)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.Id_Author);

        modelBuilder.Entity<Book>()
            .HasOne(x => x.Press)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.Id_Press);
    }
}