using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FitProGymManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FitPro_Gym_Membership_Manager.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly FitProDbContext _context;

        public IndexModel(FitProDbContext context)
        {
            _context = context;
            Members = new List<Member>();
            SearchString = string.Empty;
            CurrentSort = string.Empty;
        }

        public IList<Member> Members { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public string CurrentSort { get; set; }

        public async Task OnGetAsync(int? pageNumber)
        {
            const int PageSize = 10;
            CurrentPage = pageNumber ?? 1;

            var query = _context.Members.AsQueryable();

            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(m => 
                    (m.FirstName != null && m.FirstName.Contains(SearchString)) ||
                    (m.LastName != null && m.LastName.Contains(SearchString)) ||
                    (m.Email != null && m.Email.Contains(SearchString)) ||
                    (m.PhoneNumber != null && m.PhoneNumber.Contains(SearchString)));
            }

            query = CurrentSort switch
            {
                "FirstName_Desc" => query.OrderByDescending(m => m.FirstName),
                "FirstName" => query.OrderBy(m => m.FirstName),
                "LastName_Desc" => query.OrderByDescending(m => m.LastName),
                "LastName" => query.OrderBy(m => m.LastName),
                "Email_Desc" => query.OrderByDescending(m => m.Email),
                "Email" => query.OrderBy(m => m.Email),
                _ => query.OrderBy(m => m.FirstName)
            };

            var count = await query.CountAsync();
            TotalPages = (int)Math.Ceiling(count / (double)PageSize);
            CurrentPage = Math.Max(1, Math.Min(CurrentPage, TotalPages));

            Members = await query
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
        }
    }
}
