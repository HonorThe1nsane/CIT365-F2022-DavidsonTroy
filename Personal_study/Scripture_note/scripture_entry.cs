using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Personal_study.Scripture_note
{
    public class Scripture_entry
    {
        public int ID { get; set; }
        [Display(Name = "Scripture")]
        [Required]
        public string scripture_reference { get; set; }
        [Display(Name = "Scripture Text")]
        [Required]
        public string scripture_text { get; set; }
        [Display(Name = "Notes/Impressions")]
        [Required]
        public string scripture_note { get; set; }

        [Display(Name = "Date saved")]
        [Required]
        public string scripture_date { get; set; }
        
    }
}
