using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalidHotel.Domain.Models
{
    public class Room
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int FloorNumber { get; set; }
        public string Status { get; set; }
        public int RoomTypeID { get; set; }
        public RoomType Type { get; set; }
        public int HotelID { get; set; }
        public Hotel Hotel { get; set; }
    }
}
