using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormDataGridView
{
    internal class database
    {
        public static List<Musteri> musteriler =new List<Musteri>();

        public List<Musteri> musteriListele()
        {
            if(musteriler.Count == 0)
            {
                for (int i = 1; i < 1001; i++)
                {
                    Musteri M = new Musteri();
                    M.Id = 1000 + i;
                    M.isim = FakeData.NameData.GetFirstName();
                    M.soyisim = FakeData.NameData.GetSurname();
                    M.email = FakeData.NetworkData.GetEmail(M.isim, M.soyisim);
                    M.telefon = FakeData.PhoneNumberData.GetUsPhoneNumber();
                    M.Il = FakeData.PlaceData.GetCity();
                    M.Ilce = FakeData.PlaceData.GetState();
                    M.Adres = FakeData.PlaceData.GetAddress();
                    musteriler.Add(M);
                }
            }
            
            return musteriler;  
        }
    }
}
