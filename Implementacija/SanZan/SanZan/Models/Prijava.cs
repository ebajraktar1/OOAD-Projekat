using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Prijava
    {
        [Key]
        public int IDPrijave { get; set; }
        [ForeignKey("Korisnik")]
        public int IDPrijavljenog { get; set; }
        [ForeignKey("Korisnik")]
        public int IDZalbenika { get; set; }
        [EnumDataType(typeof(TipPrijave))]
        public TipPrijave TipPrijave { get; set; }
        [ForeignKey("Korisnik")]
        public int IDAdministratora { get; set; }
    }
}
