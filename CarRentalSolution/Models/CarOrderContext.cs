using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CarRentalSolution.Models
{
    public partial class CarOrderContext : DbContext
    {
        //private CarOrderContext db;

        public CarOrderContext()
        {
        }

        public CarOrderContext(DbContextOptions<CarOrderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CarOrder> CarOrder { get; set; }
        public virtual DbSet<Client> Client { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarRentalDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.CarId)
                    .HasColumnName("CarID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarClass)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarOrder>(entity =>
            {
                entity.Property(e => e.CarOrderId)
                    .HasColumnName("CarOrderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
