using Booking.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booking.Domain.Bookings;
namespace Booking.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options) { }
        public DbSet<Booking.Domain.Bookings.Book> Bookings { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<Book>()
                  .OwnsOne(u => u.HotelId);
            builder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasConversion(
                        id => id.Value,          // Convert BookingId to Guid for storage
                        value => BookingId.Of(value));  // Convert Guid to BookingId for usage

                // Configure other properties if needed
            });
            builder.Entity<Book>().OwnsOne(e => e.RoomTypeId, id =>
            {
                id.Property(i => i.Value).HasColumnName("RoomTypeId");
            });
            base.OnModelCreating(builder);
        }
    }
}
