using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Izburs.Services
{
    public class FileUpload
    {
        public async Task<string> _fncResimYukleAsync(IFormFile file)
        {
            // string DosyaAdi = Guid.NewGuid().ToString().Replace("-", "");
            // string uzanti = System.IO.Path.GetExtension(Dosya);
            // if (uzanti != "")
            // {
            //     TamYolYeri = "/Uploads/Ogrenci/" + DosyaAdi + uzanti;

            //     form.Files[0].SaveAs(Server.MapPath(TamYolYeri));
            //     form.Files[0].FileName
            // }
            // else
            // {
            //     TamYolYeri = Session["Resim"].ToString();
            // }
            //// return TamYolYeri;

            string path = "";
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);

                string imageName = Guid.NewGuid() + imageExtension;

                path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Uploads/{imageName}");
                // path = Path.Combine(Directory.GetCurrentDirectory(), "/Uploads/Ogrenci/" + imageName);

                using var stream = new FileStream(path, FileMode.Create);

                await file.CopyToAsync(stream);
                path = "/Uploads/" + imageName.ToString();
            }
            return path;
        }
    }
}
