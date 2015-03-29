using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    //EN : Concrete product  / TR : Somut ürün
    public class DBLogProvider : ILogProvider
    {
        public bool LogItem(string logText)
        {
            bool result = false;

            //EN : Write to DB / TR : Veritabanına yaz.
            //EN : Operations / Tr : İşlemler
            result = true;

            return result;

        }
    }
}
