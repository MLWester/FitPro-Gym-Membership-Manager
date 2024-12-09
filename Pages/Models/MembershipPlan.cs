using System.ComponentModel.DataAnnotations;

namespace FitProGymManager.Models
{
    public class MembershipPlan
      {
        [Key]
        public int MembershipPlanID { get; set; }

        [Required]
        [StringLength(50)]
        public string PlanName { get; set; }

        [Required]
        public decimal MonthlyFee { get; set; }

        [Required]
        public int DurationInMonths { get; set; }

        [Required]
        public int MaxMembers { get; set; }
    }
}