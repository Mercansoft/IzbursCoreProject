using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Transkript")]
    public class Transkript:BaseEntity
    {

        [Required(ErrorMessage = "Lütfen Transkriptinizi Boş Geçmeyiniz")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Sadece JPG ve PNG resim formatlarını yükleyebilirsiniz.")]
        public string Dosya { get; set; }
        public string AppUserId { get; set; }
        public int DonemId { get; set; }
        public Donem Donem { get; set; }
    }
}
