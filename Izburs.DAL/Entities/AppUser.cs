using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Izburs.DAL.Entities
{
    public class AppUser:IdentityUser
    {
        public string AdSoyad { get; set; }
    }
}
