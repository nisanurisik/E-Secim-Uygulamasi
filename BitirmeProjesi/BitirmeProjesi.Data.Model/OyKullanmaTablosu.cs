using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Model
{
    public class OyKullanmaTablosu
    {
        [Key]
        public int Id { get; set; }
        public int SecimId { get; set; }
        public int AdayId { get; set; }
        //public DateTime OyTarih { get; set; }
        //public virtual Kullanicilar Kullanici { get; set; }
        public virtual Secim Secim { get; set; }
        public virtual Aday Aday { get; set; }
    }
}
