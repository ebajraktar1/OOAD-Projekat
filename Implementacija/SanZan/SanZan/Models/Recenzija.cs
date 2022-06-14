using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Recenzija
    {
        [Key]
        public int IDRecenzije { get; set; }
        [ForeignKey("Korisnik")]
        public int IDRecenzenta { get; set; }
        [ForeignKey("Korisnik")]
        public int IDjelatnika { get; set; }
        [Required]
        public DateTime Vrijeme { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Ocjene su od 1 do 5!")]
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
    }
}
