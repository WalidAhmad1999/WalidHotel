using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalidHotel.Domain.Models;

namespace WalidHotel.Data
{
    public class HotelService
    {
        private HotelDbContext _context;

        public HotelService()
        {
            _context = new HotelDbContext();
        }


        // Create
        public void CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
        }

        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void CreateGuest(Guest guest)
        {
            _context.Guests.Add(guest);
            _context.SaveChanges();
        }
        public void CreateBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public void CreatePayment(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        // Read
        public Hotel GetHotel(int hotelId)
        {
            return _context.Hotels.Find(hotelId);
        }

        public List<Employee> GetEmployeesByHotel(int hotelId)
        {
            return _context.Employees.Where(e => e.HotelID == hotelId).ToList();
        }

        public List<Room> GetRoomsByHotel(int hotelId)
        {
            return _context.Rooms.Where(r => r.HotelID == hotelId).ToList();
        }

        public List<Booking> GetBookingsByRoom(int roomId)
        {
            return _context.Bookings.Where(b => b.RoomID == roomId).ToList();
        }

        public List<Payment> GetPaymentsByBooking(int bookingId)
        {
            return _context.Payments.Where(p => p.BookingID == bookingId).ToList();
        }

        // Update
        public void UpdateHotel(Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateBooking(Booking booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdatePayment(Payment payment)
        {
            _context.Entry(payment).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Delete
        public void DeleteHotel(int hotelId)
        {
            var hotel = _context.Hotels.Find(hotelId);
            if (hotel != null)
            {
                _context.Hotels.Remove(hotel);
                _context.SaveChanges();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = _context.Employees.Find(employeeId);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }

        public void DeleteRoom(int roomId)
        {
            var room = _context.Rooms.Find(roomId);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
        }

        public void DeleteBooking(int bookingId)
        {
            var booking = _context.Bookings.Find(bookingId);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
        }

        public void DeletePayment(int paymentId)
        {
            var payment = _context.Payments.Find(paymentId);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
        }
    }


}

