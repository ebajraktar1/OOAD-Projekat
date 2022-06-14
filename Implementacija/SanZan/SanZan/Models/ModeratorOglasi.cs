using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class ModeratorOglasi
    {
        [Key]
        public int IDModeratorOglasi { get; set; }
        [ForeignKey("Korisnik")]
        public int IDModeratora { get; set; }
        public Korisnik Korisnik { get; set; }
        [ForeignKey("Oglas")]
        public int IDOglasa { get; set; }
        public Oglas Oglas { get; set; }
    }
}
