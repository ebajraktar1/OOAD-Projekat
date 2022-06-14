using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public sealed class GlobalnaStatistika
    {
        [Key]
        public int IDGlobalnaStatistika;
        [Display(Name = "Broj korisnika")]
        public static int BrojKorisnika { get; set; } = 0;
        [Display(Name = "Broj oglasa")]
        public static int BrojOglasa { get; set; } = 0;
        [Display(Name = "Broj banovanih korisnika")]
        public static int BrojBanovanihKorisnika { get; set; } = 0;
        [Display(Name = "Broj uspješnih saradnji")]
        public static int BrojUspjesnihSaradnji { get; set; } = 0;

        private GlobalnaStatistika() { }
    }
}
