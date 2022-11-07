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

        public IList<Scripture_entry> Scripture_entry { get;set; }
        
        [BindProperty(SupportsGet = true)]  
        
        public string SearchString { get; set; }
        
        public SelectList ScriptureFind { get; set; }
        [BindProperty(SupportsGet = true)]
        
        public string Scripture_entryScriptureFind { get; set; }
        

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Scripture_entry
                                            orderby m.scripture_reference
                                            select m.scripture_reference;
            var scriptures = from m in _context.Scripture_entry
                             select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                Scripture_entry = await _context.Scripture_entry.Where(m => m.scripture_reference.Contains(SearchString)).ToListAsync();
            }
     
            Scripture_entry = await _context.Scripture_entry.ToListAsync();
            
            

        }
    }
}
