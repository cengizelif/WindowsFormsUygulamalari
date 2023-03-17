using System.Collections.Generic;

namespace WindowsFormOrnek4
{
    internal class sanalDatabase
    {
        public static List<Urun> urunler=new List<Urun>()
        { 
            new Urun(){ ID=1, UrunAdi="Şeker Portakalı", Kategori="Roman", Stok=50, Yazar="Jose Mauro De Vasconcelos", Aciklama="2023 basım", UrunResim=@"C:\resim\sker2.jpg"} ,
            new Urun(){ ID=2,UrunAdi="Delifişek", Kategori="Roman", Stok=50, Yazar="Jose Mauro De Vasconcelos", Aciklama="2023 basım", UrunResim=@"C:\resim\resim2.jpg"}
        };
    }
}
