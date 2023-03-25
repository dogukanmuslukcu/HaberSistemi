
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    [Table("Haber")]
    public class Haber
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Haber Baslik")]
        [MaxLength(200, ErrorMessage = "Lütfen 200 karakterden fazla değer girmeyiniz")]
        [Required]

        public string Baslik { get; set; }
        [Display(Name = "Kisa Aciklama")]

        public string KisaAciklama { get; set; }
        [Display(Name = "Aciklama")]

        public int OkunmaSayisi { get; set; }

        public string Aciklama { get; set; }
        [Display(Name = "Aktif")]

        public bool AktifMi { get; set; }
        [Display(Name = "Ekleme Tarihi")]

        public DateTime EklemeTarihi { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        [Display(Name = "Resim")]
        [MaxLength(200, ErrorMessage = "Lütfen 200 karakterden fazla değer girmeyiniz")]

        public string Resim { get; set; }

        public virtual ICollection<Resim> Resims { get; set; }



    }
}