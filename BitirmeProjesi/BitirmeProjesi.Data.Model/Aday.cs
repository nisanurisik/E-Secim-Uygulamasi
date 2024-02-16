using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Model
{
    public class Aday
    {
        public int AdayId { get; set; }
        public int KullaniciId { get; set; }
        public int SecimId { get; set; }
        public string AdayParti { get; set; }

        public virtual Kullanicilar Kullanici { get; set; }
        public virtual Secim Secim { get; set; }
    }
}
