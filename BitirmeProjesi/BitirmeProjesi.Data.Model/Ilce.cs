using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Model
{
    public class Ilce
    {
        public int IlceId { get; set; }
        public int SehirId { get; set; }
        public string IlceAdi { get; set; }

        public virtual Sehir Sehir { get; set; }
    }
}
