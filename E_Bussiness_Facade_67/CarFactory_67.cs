using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Bussiness_Facade
{
    public class CarFactory
    {
        private engineMotor engineMotor;
        private Internal_Hardware Internal_Hardware;
        private Bodywork bodywork;
        private undercarriage_parts undercarriage_Parts;  
        public CarFactory()
        {
            undercarriage_Parts = new undercarriage_parts();//ALT TAKIM
            bodywork = new Bodywork();//KAPORTA VE ISKELET 
            Internal_Hardware = new Internal_Hardware();//IC DONANIM
            engineMotor = new engineMotor();//MOTOR

            Console.WriteLine("\n\nAractaki tum alt birimler birlestirildi");
            Console.WriteLine("Kalan diger islemler yapildi");
            Console.WriteLine("Aracin diger kontrolleri yapildi ve hazir hale getirildi");
            Console.WriteLine("Arac satisa Sunuldu");
        }

    }
}
