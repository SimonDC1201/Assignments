using System.Collections.Generic;

namespace Assignment03Restaurant.DTO
{
    public class ReservationDTO
    {
        public string Name { get; set; }
        public List<MenuItemDTO> MenuItems {get; set;}
    }
}
