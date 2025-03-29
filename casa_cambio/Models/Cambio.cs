using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace casa_cambio.Models
{
    public class Cambio
    {
        [Display(Name ="cantidad")]
        public double cantidad { get; set; }
        public int opcion { get; set; }
    }
}