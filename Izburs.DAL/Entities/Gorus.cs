using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Gorus")]
    public class Gorus:BaseEntity
    {
        public string AppUserId { get; set; }
    }
}
