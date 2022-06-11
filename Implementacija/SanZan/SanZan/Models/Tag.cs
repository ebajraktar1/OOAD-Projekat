﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    //test 
    public class Tag
    {
        [Key, ForeignKey("ZahtjevTagovi")]
        public int IDTaga { get; set; }
        public string naziv { get; set; }
        public int djelatnost { get; set; }
    }
}
