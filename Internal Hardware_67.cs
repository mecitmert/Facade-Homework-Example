using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Facade
{
    public class Internal_Hardware//ic donanim
    {
        public Internal_Hardware()
        {
            Console.WriteLine("\nIC DONANIM BOLUMU");
            SteeringWheel(); //direksiyon
            consol();
            AirConditioningSystem(); //Klima
            nagivation();
            mirror();//dikiz aynasi
        }  
        private void SteeringWheel() //direksiyon
        {
            Console.WriteLine("Direksiyon Oturtuldu");
        }
        private void AirConditioningSystem() //Klima
        {
            Console.WriteLine("Klima Sistemi Eklendi ve ızgaralar monte edildi");
        }
        private void mirror()//dikiz aynasi
        {
            Console.WriteLine("Dikiz Aynasi Konuldu");
        }
        private void nagivation() => Console.WriteLine("Araba icin dokunmatik nagivasyon ve akilli tablet sistemi konuldu");
        private void consol()
        {
            Console.WriteLine("Consol dugmeleri direksiyona konuldu");
            Console.WriteLine("Sinyal , far , silgec kollari konuldu");
        }
    }
}
