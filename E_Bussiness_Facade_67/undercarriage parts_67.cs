using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Facade
{
    public class undercarriage_parts//(alt takim)  yuruyen aksan sistem ve parcalari
    {
        public undercarriage_parts() 
        {
            Console.WriteLine("\nALT TAKIM SISTEMI VE ALT TAKIM PARCA BOLUMU");
            Chassis();//Şasi
            breakk();//fren
            damper();//amortisör
            wheel();//tekerlerk
            Exhaust();//Egzoz
            Differential();//Diferansiyel
            Transmission();//vites kutusu


        }

        private void Exhaust()//Egzoz
        {
            Console.WriteLine(" Alt sisteme Egzoz monte edildi");
        }
        private void Transmission() //vites kutusu
        {
            Console.WriteLine("Sanziman kontrolu yapildi");
        }
        private void Chassis()//Şasi
        {
            Console.WriteLine("Şasi Oluşturuldu");
        }
        private void Differential()
        {
            Console.WriteLine("Diferansiyel ayarlari Yapildi");
        }
        private void damper()//amortisör
        {
            Console.WriteLine("Amortisör Şasiye eklendi");
        }
        private void wheel() //tekerlerk
        {
            Console.WriteLine("Tekerlekler Takildi");
        }
        private void breakk() //fren
        {
            Console.WriteLine("balatalar ve fren sistemi yerlestrirldi");
        }

    }
}
