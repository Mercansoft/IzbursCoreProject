using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Izburs.DAL.Entities
{
    [Table("Kullanici")]
    public class Kullanici : BaseEntity
    {
        [Required(ErrorMessage = "Lütfen Adınızı Yazınız")]
        [StringLength(50)]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Yazınız")]
        [StringLength(50)]
        public string Soyad { get; set; }
        [EmailAddress(ErrorMessage = "Lütfen Email Formatında giriniz")]
        [Required(ErrorMessage = "Lütfen Email Yazınız")]
        [StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen TC Kimlik Numaranızı Yazınız")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "TcKimlikNo : Lütfen sadece rakam yazınız")]
        public string TcKimlikNo { get; set; }
        [Required(ErrorMessage = "Doğum Tarihinizi Giriniz")]
        public DateTime DogumTarihi { get; set; }
        [Required(ErrorMessage = "Lütfen Resim yükleyiniz")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Sadece JPG ve PNG resim formatlarını yükleyebilirsiniz.")]
        public string Resim { get; set; }
        public string Adres { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Telefon : Lütfen sadece rakam yazınız")]
        [Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz")]
        public string Telefon { get; set; }
        public string Sifre { get; set; }
        [Required(ErrorMessage = "Lütfen Okul Bölümünüzü Seçiniz")]
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        [Required(ErrorMessage = "Lütfen Okulunuzu Seçiniz")]
        public int OkulId { get; set; }
        public Okul Okul { get; set; }
        public int BursDurumID { get; set; }
        public BursDurum BursDurum { get; set; }
        public int DonemID { get; set; }
        public Donem Donem { get; set; }
        [Required(ErrorMessage = "Lütfen Annenizin Mesleğini Seçiniz")]
        public int AnneMeslekID { get; set; }
        //public Meslek MeslekAnne { get; set; }
        [Required(ErrorMessage = "Lütfen Babanızın Mesleğini Seçiniz")]
        public int BabamMeslekID { get; set; }
        //public Meslek MeslekBaba { get; set; }
        [Required(ErrorMessage = "Lütfen Şehir Seçiniz")]
        public int SehirId { get; set; }
        public Sehir Sehir { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Sinif : Lütfen sadece rakam yazınız")]
        [Required(ErrorMessage = "Lütfen Sınıfınızı Yazınız")]
        public int Sinif { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Gelir : Lütfen sadece rakam yazınız")]
        [Required(ErrorMessage = "Lütfen Gelirinizi Yazınız")]
        public decimal Gelir { get; set; }
        [Required(ErrorMessage = "Lütfen Herhangibir İşte Çalışıyormusunuz? sorusunu boş geçmeyiniz")]
        public bool Is { get; set; }
        [Required(ErrorMessage = "Lütfen Başka Burs alıyormusunuz sorusunu boş Geçmeyiniz")]
        public bool BaskaBurs { get; set; }
        public string BursNerden { get; set; }
        public string UyeDernek { get; set; }
        public string OzelUgras { get; set; }
        [Required(ErrorMessage = "Lütfen Babanız Sağmı sorusunu Boş Geçmeyiniz")]
        public bool BabaSag { get; set; }
        [Required(ErrorMessage = "Lütfen Anneniz Sağmı sorusunu Boş Geçmeyiniz")]
        public bool AnneSag { get; set; }
        [Required(ErrorMessage = "Lütfen Anne Baba birliktemi sorusunu  Boş Geçmeyiniz")]
        public bool AnneBabaBirlikte { get; set; }
        [Required(ErrorMessage = "Lütfen Eviniz kiramı sorusunu  Geçmeyiniz")]
        public bool EvKirami { get; set; }
        [Required(ErrorMessage = "Lütfen Babanızın gelirini Boş Geçmeyiniz")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "BabaGelir : Lütfen sadece rakam yazınız")]
        public decimal BabaGelir { get; set; }
        [Required(ErrorMessage = "Lütfen Annenizin gelirini Boş Geçmeyiniz")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "AnneGelir : Lütfen sadece rakam yazınız")]
        public decimal AnneGelir { get; set; }
        public decimal EvKiraUcreti { get; set; }
        public string AileGayriMenkul { get; set; }
        [Required(ErrorMessage = "Lütfen Kardeşiniz varmı sorusunu Geçmeyiniz")]
        public bool KardesVarYok { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Kardeş sayısı : Lütfen sadece rakam yazınız")]
        [Required(ErrorMessage = "Lütfen Kardeş sayısı sorusunu Geçmeyiniz")]
        public int KardesSayisi { get; set; }
        public string KardesIsOkul { get; set; }
        public string AkrabaDereceGelir { get; set; }
        public string TavsiyeEdenKisi { get; set; }
        public string BilgiKisiveTelefon { get; set; }
        public string DigerBilgiler { get; set; }
        public string BankaAdi { get; set; }
        public string HesapNo { get; set; }
        public string Iban { get; set; }
        public int Puan { get; set; }
        [Required(ErrorMessage = "Lütfen Öğrenci Geliriniz sorusunu boş Geçmeyiniz")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "OgrenciGelir : Lütfen sadece rakam yazınız")]
        public decimal OgrenciGelir { get; set; }
        [Required(ErrorMessage = "Lütfen Okul Türü sorusunu boş Geçmeyiniz")]
        public int OkulTuruId { get; set; }
        public OkulTuru OkulTuru { get; set; }
    }
}
