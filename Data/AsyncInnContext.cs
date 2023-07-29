using Async_Inn_LAB12.Models;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
namespace Async_Inn_LAB12.Data
{
    public class AsyncInnContext : DbContext
    {
        public DbSet<Amenity> Amenities;
        public DbSet<RoomAmenity> RoomAmenities;
        public DbSet<Room> Rooms;
        public DbSet<HotelRoom> HotelRooms;
        public DbSet<Hotel> Hotels;

        public AsyncInnContext(DbContextOptions<AsyncInnContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amenity>().HasData(new Amenity
            {
                ID = 1,
                Name = "A/C"
            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                ID = 1,
                Layout = 0,
                Name = "Basic Room",
               
            });
            modelBuilder.Entity<Hotel>().HasData(new Hotel
            {
                ID = 1,
                Address = "123 Sesame St",
                City = "Memphis",
                State = "Tn",
                Name = "Elmo's Hotel",
                Phone = "555-555-5555"
            }); 


            // lookup table
            modelBuilder.Entity<RoomAmenity>().HasData(new RoomAmenity
            {
                ID = 1,
                AmenityID = 1,
                RoomID = 1 
            });
            modelBuilder.Entity<HotelRoom>().HasData(new HotelRoom
            {
                ID = 1,
                HotelID = 1,
                RoomID = 1,
                Price = 100.99
            });
        }
        public DbSet<Async_Inn_LAB12.Models.Hotel> Hotel { get; set; } = default!;
        public DbSet<Async_Inn_LAB12.Models.Room> Room { get; set; } = default!;
        public DbSet<Async_Inn_LAB12.Models.HotelRoom> HotelRoom { get; set; } = default!;
        public DbSet<Async_Inn_LAB12.Models.RoomAmenity> RoomAmenity { get; set; } = default!;
        public DbSet<Async_Inn_LAB12.Models.Amenity> Amenity { get; set; } = default!;

    }
}
