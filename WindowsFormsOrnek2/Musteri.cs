using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsOrnek2
{
    internal class Musteri
    {
        public Guid ID { get; set; }        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return Ad +" "+ Soyad +" "+ Email;      
        }
    }
}
