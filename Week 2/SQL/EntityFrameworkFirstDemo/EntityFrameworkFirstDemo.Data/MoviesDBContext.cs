using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.IO;



namespace EntityFrameworkFirstDemo.Data
{
    public partial class MoviesDBContext : DbContext
    {
        public MoviesDBContext()
        {
        }

        public MoviesDBContext(DbContextOptions<MoviesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MoviesGenre> MoviesGenre { get; set; }

        public string getJSONConnectionString()
        {
            using (StreamReader s = new StreamReader("C:\\Revature\\training-code\\Week 2\\SQL\\EntityFrameworkFirstDemo\\EntityFrameworkFirstDemo.ConsoleApp\\connectionString.txt"))
            {
                string connectionString = s.ReadToEnd();
                return connectionString;
            }
            
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = getJSONConnectionString();
                Console.WriteLine(connectionString);

                // Protecting connectionString Information
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genre", "Movies");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movie", "Movies");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Movie)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movie_Genre_ID");

                entity.HasOne(d => d.GenreNavigation)
                    .WithMany(p => p.Movie)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movie_Genre");
            });

            modelBuilder.Entity<MoviesGenre>(entity =>
            {
                entity.ToTable("Movies.Genre", "Movies");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });
        }
    }
}
