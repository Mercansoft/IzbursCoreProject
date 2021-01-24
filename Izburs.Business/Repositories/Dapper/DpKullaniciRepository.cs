using Dapper.Contrib.Extensions;
using Izburs.DAL.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Izburs.Business.Repositories.Dapper
{
    public class DpKullaniciRepository
    {
        public List<Kullanici> GetirHepsi()
        {
            using var connection = new SqlConnection("server=localhost;database=YotubeNetCore; user id=sa; password=@Yzq1w2e3;");
            return (List<Kullanici>)connection.GetAll<Kullanici>();
        }
    }
}
