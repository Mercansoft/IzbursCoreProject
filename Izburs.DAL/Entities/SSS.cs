using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("SSS")]
    public class SSS : BaseEntity
    {
        public string Ad { get; set; }
    }
}
