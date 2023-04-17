using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using File = Entities.Concrete.File;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class FileManagerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-43RJB7H\MSSQLDEVELOPER;Database=FileManager;Trusted_Connection=true;");
        }

        public DbSet<Folder> Folders { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>()
                .HasOne<Folder>(f => f.Folder)
                .WithMany(d => d.Files);

            modelBuilder.Entity<Folder>()
                .HasOne<User>(f => f.User)
                .WithMany(u => u.Folders)
                .HasForeignKey(f=>f.UserId);

            modelBuilder.Entity<Extension>()
                .HasIndex(e => e.Name)
                .IsUnique();

        }
    }
}
