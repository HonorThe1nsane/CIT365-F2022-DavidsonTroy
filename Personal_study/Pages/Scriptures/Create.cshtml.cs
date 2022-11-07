using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Personal_study.Data;
using Personal_study.Scripture_note;

namespace Personal_study.Pages.Scriptures
{
    public class CreateModel : PageModel
    {
        private readonly Personal_study.Data.Personal_studyContext _context;

        public CreateModel(Personal_study.Data.Personal_studyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Scripture_entry Entry { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Entry.scripture_date = getDate(Entry);

            _context.Scripture_entry.Add(Entry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public string getDate(Scripture_entry entry)

        {
            DateTime dt = DateTime.Now;
            entry.scripture_date = dt.ToString("MM/dd/yyyy");

            return entry.scripture_date;

        }
    }
}
