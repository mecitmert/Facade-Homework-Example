using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Facade
{
    public class Bodywork//Kaporta
    {
        public Bodywork() {
            Console.WriteLine("\nKAPORTA VE ISKELET BOLUMU");
            Console.WriteLine("Kaporta:" +
                "Kaput , " +
                "Tavan , " +
                "On ve Arka Tampon , " +
                "Kapilar , " +
                "On ve Arka Camurluklar Eklendi");
            Color();
        }

        private void Color() => Console.WriteLine("Kaporta Boya Islemi Gerceklesti");
        
    }
}
