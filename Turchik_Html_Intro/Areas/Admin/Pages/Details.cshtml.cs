using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Turchik_Html_Intro.DAL.Data;
using Turchik_Html_Intro.DAL.Entities;

namespace Turchik_Html_Intro.Areas.Admin.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Turchik_Html_Intro.DAL.Data.ApplicationDbContext _context;

        public DetailsModel(Turchik_Html_Intro.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Drug Drug { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Drug = await _context.Drugs
                .Include(d => d.Group).FirstOrDefaultAsync(m => m.Id == id);

            if (Drug == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
