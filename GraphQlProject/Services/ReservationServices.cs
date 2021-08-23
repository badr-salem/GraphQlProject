using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Services
{
    public class ReservationServices : IReservation
    {
        private GraphQlDbContext _context;

        public ReservationServices(GraphQlDbContext context)
        {
            _context = context;
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
            return _context.Reservations.ToList();
        }
    }
}
