using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Model
{
    public class Kullanicilar
    {
        [Key]
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string KullaniciTc { get; set; }
        public DateTime KullaniciDogumTarihi { get; set; }
        public string KullaniciYetki { get; set; }
        public string KullaniciOyDurumu { get; set; }

        //public virtual Ilce Ilce { get; set; }

        [Required]
        public string KullaniciSifre { get; set; }

        [Required]
        public string KullaniciGirisAdi { get; set; }
    }
}
