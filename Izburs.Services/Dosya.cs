using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Izburs.Services
{
    public static class Dosya
    {
        public static bool DosyaSil(string yol)
        {
            
            try
            {
                var abs = Path.GetFullPath(yol.ToString());
               // string tamyol = HostingEnvironment.ApplicationPhysicalPath + yol.ToString();
                File.Delete(yol);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
