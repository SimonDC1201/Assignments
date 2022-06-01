using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment03.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        //public List<MenuItem> MenuItems { get; set; }
    }
}
