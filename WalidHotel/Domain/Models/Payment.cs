using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalidHotel.Domain.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Notes { get; set; }
        public int BookingID { get; set; }
        public Booking Booking { get; set; }
    }
}
