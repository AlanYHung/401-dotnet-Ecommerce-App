using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Data
{
  public class ECommerceDbContext
  {
{
    public AsyncInnDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Amenity> Amenities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<RoomAmenities>().HasKey(
          roomAmenities => new { roomAmenities.RoomId, roomAmenities.AmenityId });
      modelBuilder.Entity<HotelRoom>().HasKey(
         hotelRooms => new { hotelRooms.HotelId, hotelRooms.RoomNumber });
    }

  } // end of class
} // end of namespace