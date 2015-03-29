using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BCargoIntegration
{
    //EN: Notice the AcceptCargo method signitures is (a little bit) different from ACargoIntegration / AcargoIntegration a göre, AcceptCargo metodunun parametre listesi (biraz) farklıdır.
    //EN : There are Incompatible interfaces / RE : Uyumsuz arayüzler var.
    public class BCargoAdaptee
    {
        public bool AcceptCargo(string cargoId,string customerName,string customerAdress,string customerPhone)
        {
            bool result;

            //Operations / işlemler
            result = true;

            return result;
        }
    }
}
