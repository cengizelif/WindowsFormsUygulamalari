using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosyave_KlasörOrnek
{
    public class database
    {
        public List<Personel> personeller = new List<Personel>();
        public List<Personel> PersonelGetir(int adet)
        {
            for (int i = 0; i < adet; i++)
            {
                Personel p = new Personel();
                p.Id = i + 1;
                p.isim = FakeData.NameData.GetFirstName();
                p.soyisim=FakeData.NameData.GetSurname();
                p.firmaAdi = FakeData.NetworkData.GetDomain();
                p.email = p.isim + "." + p.soyisim + "@" + p.firmaAdi;
                p.ulke = FakeData.PlaceData.GetCountry();
                personeller.Add(p);
            }
            return personeller; 
        }
    }
}
