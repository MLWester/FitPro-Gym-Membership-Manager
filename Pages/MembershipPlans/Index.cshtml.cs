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
    public class IndexModel : PageModel
    {
        private readonly FitProGymManager.Models.FitProDbContext _context;

        public IndexModel(FitProGymManager.Models.FitProDbContext context)
        {
            _context = context;
        }

        public IList<MembershipPlan> MembershipPlan { get;set; } = default!;

        public async Task OnGetAsync()
        {
            MembershipPlan = await _context.MembershipPlans.ToListAsync();
        }
    }
}
