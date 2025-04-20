using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FitProGymManager.Models;

namespace FitPro_Gym_Membership_Manager.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly FitProGymManager.Models.FitProDbContext _context;

        public DetailsModel(FitProGymManager.Models.FitProDbContext context)
        {
            _context = context;
        }

        public Member Member { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members.FirstOrDefaultAsync(m => m.MemberID == id);

            if (member is not null)
            {
                Member = member;
                return Page();
            }

            return NotFound();
        }
    }
}
