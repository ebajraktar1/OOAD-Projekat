using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanZan.Models
{
    public enum TipDjelatnika
    {
        [Display(Name = "Obični")]
        Obicni,
        [Display(Name = "Premium")]
        Premium
    }
}
