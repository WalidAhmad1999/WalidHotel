using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalidHotel.Domain.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        // Navigation properties
        public List<Employee> Employees { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
