using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMs.Models
{
    public class ApplicationUserM:IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public int? CustomerNumber { get; set; }
        public int? Age { get; set; }
        

        public string? Gander { get; set; }
        

        public string? Phone { get; set; }
        
        public string? SubscriptionPlan { get; set; }
        
        public string? SubscriptionStatus { get; set; }

        public int? SubscriptionDuration { get; set; }

        public DateOnly? SubscriptionDate { get; set; }
		



	}
}
