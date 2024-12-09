using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FitProGymManager.Models;

namespace FitPro_Gym_Membership_Manager.Pages_MembershipPlans
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
            return Page();
        }

        [BindProperty]
        public MembershipPlan MembershipPlan { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MembershipPlans.Add(MembershipPlan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
