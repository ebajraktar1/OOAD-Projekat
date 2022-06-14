using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Korisnik
    {
        [Key, ForeignKey("Oglas")]
        public int IDKorisnika { get; set; }
        [Required]
        [Display(Name = "Korisničko ime")]
        [RegularExpression(@"[0-9|a-z|A-Z]*", ErrorMessage = "Dozvoljeno je korištenje samo slova i brojeva!")]
        public string KorisnickoIme { get; set; }
        [Required]
        [RegularExpression(@"[a-z|A-Z]*", ErrorMessage = "Dozvoljeno je korištenje samo velikih i malih slova!")]
        public string Ime { get; set; }
        [Required]
        [RegularExpression(@"[a-z|A-Z]*", ErrorMessage = "Dozvoljeno je korištenje samo velikih i malih slova!")]
        public string Prezime { get; set; }
        [Required]
        [RegularExpression(@"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}", ErrorMessage = "Lozinka mora da sadrži bar jedno malo slovo, jedno veliko slovo i jedan broj, te da bude duža od 8 karaktera")]
        public string Lozinka { get; set; }
        [ForeignKey("Kartica")]
        public int IDKartice { get; set; }
        [Required]
        [Display(Name = "Broj telefona")]
        [RegularExpression(@"[0-9]+", ErrorMessage = "Broj telefona se sastoji samo od brojeva!")]
        public string BrojTelefona { get; set; }
        [ForeignKey("Lokacija")]
        public int LokacijaId { get; set; }
        public string NazivRadnje { get; set; }
        [EnumDataType(typeof(TipDjelatnika))]
        public TipDjelatnika TipDjelatnika { get; set; }
        [EnumDataType(typeof(Djelatnost))]
        public Djelatnost Djelatnost { get; set; }

        public bool Banovan { get; set; } = false;
        [ForeignKey("Korisnik")]
        public int IDAdministratora { get; set; }
    }
}
