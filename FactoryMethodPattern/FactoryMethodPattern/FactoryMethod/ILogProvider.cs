using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    //EN : Abstraction for family of products. Product = LogProvider / TR : Bir ürün ailesi için soyutlama. Ürün = Log Kaynağı
    //EN : It is very easy to extend. (Remember OCP) / TR : Kolay genişletilebilir. OCP 'yi hatırlayınız.
    public interface ILogProvider
    {
        Boolean LogItem (string logText);
    }
}
