using WalidHotel.Data;
using WalidHotel.Domain.Models;

namespace WalidHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HotelService hotel = new HotelService();

            Console.WriteLine("Add Hotel ");

            hotel.CreateHotel(new Hotel { Name = "HH",Address="uuu"});

            // add employee
            Employee emp1 = new Employee() { FirstName = "g" };
            hotel.CreateEmployee(emp1);

            //add room
            RoomType type1 = new RoomType() {NumOfBeds=45 };//ADD ROOM TYPE
            Room room1 = new Room() { FloorNumber=2,Type = type1 }; // ADD ROOM
            hotel.CreateRoom(room1);


            //add Guest
            hotel.CreateGuest(new Guest() { FirstName = "WAlid" });


        }
    }
}