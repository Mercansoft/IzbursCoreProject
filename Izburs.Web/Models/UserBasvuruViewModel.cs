using Izburs.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Izburs.Web.Models
{
    public class UserBasvuruViewModel
    {
        public AppUser User { get; set; }
        public ICollection<Basvuru> Basvurular { get; set; }
    }
}
