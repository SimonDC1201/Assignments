using System.ComponentModel.DataAnnotations;

namespace Assignment03.Models
{
    public class MenuItem
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
