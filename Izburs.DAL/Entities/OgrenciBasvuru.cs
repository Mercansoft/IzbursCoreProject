using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("OgrenciBasvuru")]
    public class OgrenciBasvuru
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BasvuruId { get; set; }
        public Basvuru Basvuru { get; set; }
        public string AppUserId { get; set; }
    }
}
