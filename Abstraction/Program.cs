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
        public class GörevBelirleyici : Calisan
        {
            public override void Gorev()
            {
                Console.WriteLine($"{Ad} {Soyad}: Şirketin  {Departman} departmanında çalışıyorum.");
            }
        }
        static void Main(string[] args)
        {
            GörevBelirleyici projeYoneticisi = new GörevBelirleyici
            {
                Ad = "Hasan",
                Soyad = "Çıldırmış",
                Departman = "Proje Yönetimi"
            };
            GörevBelirleyici yazilimGelistirici = new GörevBelirleyici
            {
                Ad = "Ahmet",
                Soyad = "Yılmaz",
                Departman = "Yazılım"
            };
            GörevBelirleyici satisTemsilcisi = new GörevBelirleyici
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
