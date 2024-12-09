using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitProGymManager.Models
{   
    public class Member {
        [Key]
        public int MemberID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }

        [Required]
        public int MembershipPlanID { get; set; }

        [ForeignKey("MembershipPlanID")]
        public MembershipPlan MembershipPlan { get; set; }
    }
}
