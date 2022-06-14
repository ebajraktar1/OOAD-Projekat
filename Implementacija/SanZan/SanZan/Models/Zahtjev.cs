using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Zahtjev
    {
        [Key]
        public int IDZahtjeva { get; set; }
        [ForeignKey("Korisnik")]
        public int IDKlijenta { get; set; }
        public DateTime VrijemeZahtjeva { get; set; }
        [EnumDataType(typeof(Djelatnost))]
        public Djelatnost Djelatnost { get; set; }
        [ForeignKey("Lokacija")]
        public int IDLokacija { get; set; }
    }
}
