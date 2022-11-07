using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personal_study.Scripture_note;

namespace Personal_study.Data
{
    public class Personal_studyContext : DbContext
    {
        public Personal_studyContext (DbContextOptions<Personal_studyContext> options)
            : base(options)
        {
        }

        public DbSet<Personal_study.Scripture_note.Scripture_entry> Scripture_entry { get; set; }
    }
}
