using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Model
{
    public class Secim
    {
        public int SecimId { get; set; }
        public string SecimAdi { get; set; }

        [Required]
        public DateTime SecimBaslangic { get; set; }

        [Required]
        public DateTime SecimBitis { get; set; }
    }
}
