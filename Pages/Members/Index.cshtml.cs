using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FitProGymManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FitPro_Gym_Membership_Manager.Pages_Members
{
    public class IndexModel : PageModel
    {
        private readonly FitProDbContext _context;

        public IndexModel(FitProDbContext context)
        {
            _context = context;
        }

        public IList<Member> Members { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        [BindProperty(SupportsGet = true)] // Enables binding for the search string
        public string SearchString { get; set; }

        public string CurrentSort { get; set; }

        public async Task OnGetAsync(int? pageNumber)
        {
            const int PageSize = 10; // Number of members per page
            CurrentPage = pageNumber ?? 1; // Default to page 1 if no page number is provided

            var query = _context.Members.AsQueryable();

            // Apply search filter if SearchString is not null or empty
            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(m => m.FirstName.Contains(SearchString) ||
                                        m.LastName.Contains(SearchString) ||
                                        m.Email.Contains(SearchString) ||
                                        m.PhoneNumber.Contains(SearchString));
            }

            // Apply sorting based on CurrentSort
            query = CurrentSort switch
            {
                "FirstName_Desc" => query.OrderByDescending(m => m.FirstName),
                "JoinDate" => query.OrderBy(m => m.JoinDate),
                "JoinDate_Desc" => query.OrderByDescending(m => m.JoinDate),
                _ => query.OrderBy(m => m.FirstName), // Default sorting by FirstName
            };

            // Apply pagination after sorting
            var totalMembers = await query.CountAsync();
            TotalPages = (int)Math.Ceiling(totalMembers / (double)PageSize);

            Members = await query
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
        }
    }
}
