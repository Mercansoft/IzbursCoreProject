using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Yorum")]
    public class Yorum:BaseEntity
    {
        public int HaberId { get; set; }
        public Haber Haber { get; set; }
        [Required(ErrorMessage = "Lütfen Adınızı Soyadınızı Boş Geçmeyiniz")]
        [MaxLength(100)]
        public string AdSoyad { get; set; }
        [Required(ErrorMessage = "Lütfen Email Adresinizi Boş Geçmeyiniz")]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Yorumu Boş Geçmeyiniz")]
        public string Mesaj { get; set; }

    }
}
