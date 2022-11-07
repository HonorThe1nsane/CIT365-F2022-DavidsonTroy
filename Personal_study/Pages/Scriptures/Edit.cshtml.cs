using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Personal_study.Data;
using Personal_study.Scripture_note;

namespace Personal_study.Pages.Scriptures
{
    public class EditModel : PageModel
    {
        private readonly Personal_study.Data.Personal_studyContext _context;

        public EditModel(Personal_study.Data.Personal_studyContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Scripture_entry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Scripture_entryExists(Scripture_entry.ID))
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

        private bool Scripture_entryExists(int id)
        {
            return _context.Scripture_entry.Any(e => e.ID == id);
        }
    }
}
