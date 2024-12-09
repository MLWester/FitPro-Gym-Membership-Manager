using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitProGymManager.Models;

namespace FitPro_Gym_Membership_Manager.Pages_MembershipPlans
{
    public class EditModel : PageModel
    {
        private readonly FitProGymManager.Models.FitProDbContext _context;

        public EditModel(FitProGymManager.Models.FitProDbContext context)
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

            var membershipplan =  await _context.MembershipPlans.FirstOrDefaultAsync(m => m.MembershipPlanID == id);
            if (membershipplan == null)
            {
                return NotFound();
            }
            MembershipPlan = membershipplan;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MembershipPlan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembershipPlanExists(MembershipPlan.MembershipPlanID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MembershipPlanExists(int id)
        {
            return _context.MembershipPlans.Any(e => e.MembershipPlanID == id);
        }
    }
}
