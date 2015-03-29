using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod
{
    //EN : Concrete product  / TR : Somut ürün
    public class TextFileLogProvider : ILogProvider
    {
        public bool LogItem(string logText)
        {
            bool result = false;

            //EN : Write to text file / TR : Text dosyasına yaz.
            //EN : Operations / Tr : İşlemler
            result = true;

            return result;

        }
    }
}
