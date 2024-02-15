using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GymMs.Models
{
    public class UserM
    {
        [Key] 
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        
        public string Name { get; set; }
        [Required]
        [Range(0, 110,ErrorMessage ="Please Enter a Valid Number")] // Custom erroe message

        public int Age { get; set; }
        [Required]
        [MaxLength(50)]
        
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
        [MaxLength(50)]
        public string SubscriptionPlan { get; set; }
        [Required]
        [MaxLength(50)]
        public string SubscriptionStatus { get; set; }




	}
}
