using Microsoft.EntityFrameworkCore;
using Reservation.Models;

namespace Reservation.Data
{
    public class ReservationManagment : DbContext
    {
        public ReservationManagment(DbContextOptions<ReservationManagment> options) : base(options)
        {
        }

        public DbSet<Sala> Sale { get; set; }
        public DbSet<Rezerwacja> Rezerwacje { get; set; }
        public DbSet<User> Users { get; set; }
    }
}