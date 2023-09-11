using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Zbw.Carrent.Customer.Domain;
using Zbw.Carrent.Customer.Domain.Categories;

namespace Zbw.Carrent.Customer.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Domain.Customer.Customer> Customers { get; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Customer.Customer>()
                .HasKey(c => c.CustomerNr);
            modelBuilder.Entity<Domain.Customer.Customer>()
                .HasOne(c => c.Address)
                .WithMany(a => a.Customer)
                .HasForeignKey(a => a.AddressId);
            modelBuilder.Entity<Domain.Customer.Customer>()
                .HasMany(c => c.Reservations)
                .WithOne(r => r.Customers);

            modelBuilder.Entity<Address>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Domain.Reservation>()
                .HasKey(c => c.ReservationNr);

            modelBuilder.Entity<RentalContract>()
                .HasKey(r => r.ContractNr);
            modelBuilder.Entity<RentalContract>()
                .HasOne(r => r.Car)
                .WithMany(c => c.RentalContracts)
                .HasForeignKey(r => r.CarId);
            modelBuilder.Entity<RentalContract>()
                .HasOne(r => r.Reservation)
                .WithMany(r => r.RentalContracts)
                .HasForeignKey(r => r.ReservationId);

            modelBuilder.Entity<Car>()
                .HasKey(c => c.CarNr);
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Model)
                .WithOne(m => m.Car)
                .HasForeignKey<Car>(c => c.ModelId);
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Brand)
                .WithOne(b => b.Car)
                .HasForeignKey<Car>(c => c.BrandId);
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Category)
                .WithMany(c => c.Cars)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryId);

            modelBuilder.Entity<Economy>();
            modelBuilder.Entity<Midrange>();
            modelBuilder.Entity<Luxury>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
