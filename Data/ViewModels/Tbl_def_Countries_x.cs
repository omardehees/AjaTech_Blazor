using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alsharq.Data.Tables_Models
{
    public class Tbl_def_Countries_x
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "اسم الدولة مطلوب")]
        [StringLength(12, ErrorMessage = "غير مسموح باكثر من 50 حرف")]
        public string Country_Title_Ar { get; set; }
        [Required(ErrorMessage = "اسم الدولة مطلوب")]
        [StringLength(12, ErrorMessage = "غير مسموح باكثر من 50 حرف")]
        public string Country_Title_En { get; set; }
        public string Description { get; set; }
       
    }
}
