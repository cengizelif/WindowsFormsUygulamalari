using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsOrnek1
{
    internal class sanalDatabase
    {
        public static List<Kullanici> kullanicilar = new List<Kullanici>();

        static sanalDatabase()
        {
        
            kullanicilar.Add(new Kullanici()
            {
                ID = 1,
                Ad = "elif",
                Soyad = "cengiz",
                KullanciAdi = "elif",
                Sifre = "1234",
                Aciklama = "Yönetici Kullanıcı"
            });
            kullanicilar.Add(new Kullanici()
            {
                ID = 2,
                Ad = "elif",
                Soyad = "cengiz",
                KullanciAdi = "admin",
                Sifre = "1234",
                Aciklama = "Admin Kullanıcı"
            });
        }
    }
}
