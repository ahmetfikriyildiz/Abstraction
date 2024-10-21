using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Program
    {
        public abstract class Calisan
        {
            // Ortak Özellikler
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Departman { get; set; }
            // Abstract Metot 
            public abstract void Gorev();
        }
        public class YazilimGelistirici : Calisan
        {
            public override void Gorev()
            {
                Console.WriteLine($"{Ad} {Soyad}: Yazılım Geliştirici olarak çalışıyorum.");
            }
        }
        public class SatisTemsilcisi : Calisan
        {
            public override void Gorev()
            {
                Console.WriteLine($"{Ad} {Soyad}: Satış Temsilcisi olarak çalışıyorum.");
            }
        }
        public class ProjeYoneticisi : Calisan
        {
            public override void Gorev()
            {
                Console.WriteLine($"{Ad} {Soyad}: Proje Yöneticisi olarak çalışıyorum.");
            }
        }
        static void Main(string[] args)
        {
            ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi
            {
                Ad = "Hasan",
                Soyad = "Çıldırmış",
                Departman = "Proje Yönetimi"
            };
            YazilimGelistirici yazilimGelistirici = new YazilimGelistirici
            {
                Ad = "Ahmet",
                Soyad = "Yılmaz",
                Departman = "Yazılım"
            };
            SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi
            {
                Ad = "Ayşe",
                Soyad = "Demir",
                Departman = "Satış"
            };
            // Çalışanların görevlerini yazdırma
            projeYoneticisi.Gorev();  
            yazilimGelistirici.Gorev();  
            satisTemsilcisi.Gorev();  

            Console.ReadKey();
        }
    }
}
