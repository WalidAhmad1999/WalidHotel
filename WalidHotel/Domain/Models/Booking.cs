using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalidHotel.Domain.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public DateTime CheckinAt { get; set; }
        public DateTime CheckoutAt { get; set; }
        public decimal Price { get; set; }
        public int RoomID { get; set; }
        public Room Room { get; set; }
        public int GuestID { get; set; }
        public Guest Guest { get; set; }
    }
}
