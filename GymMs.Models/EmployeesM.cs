using System.ComponentModel.DataAnnotations;

namespace GymMs.Models
{
    public class EmployeesM
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]

        public string Name { get; set; }
        [Required]
        [Range(0, 110)]
        public int Age { get; set; }
        [Required]
        [MaxLength(250)]

        public string Gander { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [MaxLength(250)]

        public string Job { get; set; }
    }
}
