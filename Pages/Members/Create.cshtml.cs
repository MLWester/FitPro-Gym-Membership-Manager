using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FitProGymManager.Models;

namespace FitPro_Gym_Membership_Manager.Pages_Members
{
    public class CreateModel : PageModel
    {
        private readonly FitProGymManager.Models.FitProDbContext _context;

        public CreateModel(FitProGymManager.Models.FitProDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MembershipPlanID"] = new SelectList(_context.MembershipPlans, "MembershipPlanID", "PlanName");
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Members.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
