using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Statistika
    {
        [Key]
        public int IDDjelatnika { get; set; }
        [Display(Name = "Broj uspješnih saradnji")]
        public int BrojUspjesnihSaradnji { get; set; }
        [Display(Name = "Broj posjeta")]
        public int BrojPosjeta { get; set; }
        [Display(Name = "Broj prijava")]
        public int BrojPrijava { get; set; }
        [Display(Name = "Broj učešća")]
        public int BrojUcesca { get; set; }
    }
}
