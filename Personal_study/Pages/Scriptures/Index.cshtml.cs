using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Personal_study.Data;
using Personal_study.Scripture_note;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace Personal_study.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly Personal_study.Data.Personal_studyContext _context;

        public IndexModel(Personal_study.Data.Personal_studyContext context)
        {
            _context = context;
        }

        public IList<Scripture_entry> Scripture_entry { get; set; } = default!;
        

        [BindProperty(SupportsGet = true)]  
        
        public string? SearchString { get; set; }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }



        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "NameDesc" : "";
            DateSort = sortOrder == "Date" ? "DateDesc" : "Date";

            var scriptures = from m in _context.Scripture_entry
                             select m;
            switch (sortOrder)
            {
                case "DateSort":
                    scriptures = scriptures.OrderBy(n => n.scripture_date);
                    break;
                case "DateDesc":
                    scriptures = scriptures.OrderByDescending(n => n.scripture_date);
                    break;
                case "NameDesc":
                    scriptures = scriptures.OrderByDescending(n => n.scripture_reference);
                    break;
                default:
                    scriptures = scriptures.OrderBy(n => n.scripture_reference);
                    break;
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => (s.scripture_reference.Contains(SearchString)) || (s.scripture_text.Contains(SearchString)));

            }
            Scripture_entry = await scriptures.ToListAsync();
            
            

            
            

        }

       
    }
}
