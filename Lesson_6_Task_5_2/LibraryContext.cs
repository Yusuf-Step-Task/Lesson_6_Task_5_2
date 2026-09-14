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
        optionsBuilder.UseSqlServer( "Server=DESKTOP-E4QE067\\SQLEXPRESS01;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True" );
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


        modelBuilder.Entity<Teacher>()
            .HasOne(x => x.Department)
            .WithMany(x => x.Teachers)
            .HasForeignKey(x => x.Id_Dep);


        modelBuilder.Entity<Group>()
            .HasOne(x => x.Faculty)
            .WithMany(x => x.Groups)
            .HasForeignKey(x => x.Id_Faculty);


        modelBuilder.Entity<Student>()
            .HasOne(x => x.Group)
            .WithMany(x => x.Students)
            .HasForeignKey(x => x.Id_Group);


        modelBuilder.Entity<T_Card>()
            .HasOne(x => x.Teacher)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Teacher);

        modelBuilder.Entity<T_Card>()
            .HasOne(x => x.Book)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Book);

        modelBuilder.Entity<T_Card>()
            .HasOne(x => x.Lib)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Lib);


        modelBuilder.Entity<S_Card>()
            .HasOne(x => x.Student)
            .WithMany(x => x.S_Cards)
            .HasForeignKey(x => x.Id_Student);

        modelBuilder.Entity<S_Card>()
            .HasOne(x => x.Book)
            .WithMany(x => x.S_Cards)
            .HasForeignKey(x => x.Id_Book);

        modelBuilder.Entity<S_Card>()
            .HasOne(x => x.Lib)
            .WithMany(x => x.S_Cards)
            .HasForeignKey(x => x.Id_Lib);
    }
}