using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Oglas
    {
        [Key, ForeignKey("ModeratorOglasi")]
        public int IDOglasa { get; set; }
        [ForeignKey("Korisnik")]
        public int IDDjelatnika { get; set; }
        [Required]
        [Display(Name = "Naziv shopa")]
        public string NazivShopa { get; set; }
        [ForeignKey("Lokacija")]
        public int LokacijaID { get; set; }
        public double Ocjena { get; set; }
        [Required]
        public string Opis { get; set; }
        [ForeignKey("Status")]
        public int Status { get; set; }
    }
}
