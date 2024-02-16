using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Model
{
    public class Kampanya
    {
        public int KampanyaId { get; set; }
        public string KampanyaBaslik { get; set; }
        public string KampanyaMetni { get; set; }
        public string KampanyaAday { get; set; }
    }
}
