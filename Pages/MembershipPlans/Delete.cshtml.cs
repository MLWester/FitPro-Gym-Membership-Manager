using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FitProGymManager.Models;

namespace FitPro_Gym_Membership_Manager.Pages_MembershipPlans
{
    public class DeleteModel : PageModel
    {
        private readonly FitProGymManager.Models.FitProDbContext _context;

        public DeleteModel(FitProGymManager.Models.FitProDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MembershipPlan MembershipPlan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membershipplan = await _context.MembershipPlans.FirstOrDefaultAsync(m => m.MembershipPlanID == id);

            if (membershipplan is not null)
            {
                MembershipPlan = membershipplan;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membershipplan = await _context.MembershipPlans.FindAsync(id);
            if (membershipplan != null)
            {
                MembershipPlan = membershipplan;
                _context.MembershipPlans.Remove(MembershipPlan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
