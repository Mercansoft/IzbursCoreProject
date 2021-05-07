using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Izburs.Services
{
    public static class MailGonder
    {
        //public static bool Gonder()
        //{
        //    try
        //    {
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //   }
        //}
        public static bool Gonder(string Konu, string Icerik)
        {
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 465;
                sc.Host = "smtp.yandex.com.tr";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("info@izburs.com", "zlszuefeirskahhb");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("info@izburs.com", "Izburs Web Mail");
                mail.To.Add("info@izburs.com");
                mail.Subject = Konu;
                mail.IsBodyHtml = true;
                mail.Body = Icerik;

                sc.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool _MailGonder(string Konu, string Icerik)
        {
            bool durum = false;
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 465;
                sc.Host = "smtp.yandex.com.tr";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("info@izburs.com", "zlszuefeirskahhb");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("info@izburs.com", "Izburs Web Mail");
                mail.To.Add("info@izburs.com");
                mail.Subject = Konu;
                mail.IsBodyHtml = true;
                mail.Body = Icerik;

                sc.Send(mail);
                durum = true;
            }
            catch (Exception ex)
            {

            }
            return durum;
        }
        public static bool Gonder(string Konu, string Icerik,string AliciMail)
        {
            var _host = "smtp.yandex.com";
            var _port = 587;
            var _defaultCredentials = false;
            var _enableSsl = true;
            var _emailfrom = "info@izburs.com";//Your yandex email adress
            var _password = "zlszuefeirskahhb";//Your yandex app password
            try
            {
                using (var smtpClient = new SmtpClient(_host, _port))
                {
                    smtpClient.EnableSsl = _enableSsl;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = _defaultCredentials;
                    if (_defaultCredentials == false)
                    {
                        smtpClient.Credentials = new NetworkCredential(_emailfrom, _password);
                    }

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("info@izburs.com", "Izburs Mail Servisi");
                    mail.To.Add(AliciMail);
                    mail.Subject = Konu;
                    mail.IsBodyHtml = true;
                    mail.Body = Icerik;

                    //smtpClient.Send(_emailfrom, AliciMail, Konu, Icerik);
                    smtpClient.Send(mail);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
