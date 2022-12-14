using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Personal_study.Data;
using Personal_study.Scripture_note;

namespace Personal_study.Pages.Scriptures
{
    public class DeleteModel : PageModel
    {
        private readonly Personal_study.Data.Personal_studyContext _context;

        public DeleteModel(Personal_study.Data.Personal_studyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Scripture_entry Scripture_entry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scripture_entry = await _context.Scripture_entry.FirstOrDefaultAsync(m => m.ID == id);

            if (Scripture_entry == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scripture_entry = await _context.Scripture_entry.FindAsync(id);

            if (Scripture_entry != null)
            {
                _context.Scripture_entry.Remove(Scripture_entry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
