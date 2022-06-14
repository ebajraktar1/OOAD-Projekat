﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    [NotMapped]
    public sealed class GlobalnaStatistika
    {
        private static GlobalnaStatistika instance = new GlobalnaStatistika();
        [Display(Name = "Broj korisnika")]
        public static int BrojKorisnika { get; set; } = 0;
        [Display(Name = "Broj oglasa")]
        public static int BrojOglasa { get; set; } = 0;
        [Display(Name = "Broj banovanih korisnika")]
        public static int BrojBanovanihKorisnika { get; set; } = 0;
        [Display(Name = "Broj uspješnih saradnji")]
        public static int BrojUspjesnihSaradnji { get; set; } = 0;

        private GlobalnaStatistika() { }
        public static GlobalnaStatistika Instance 
        {
            get { return instance; }
        }
    }
}
