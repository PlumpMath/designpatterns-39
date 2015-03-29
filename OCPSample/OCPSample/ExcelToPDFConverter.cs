using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSample
{
    class ExcelToPDFConverter : IPDFConverter
    {
        //EN : Implementation of PDFConvert / TR:PDF e dönüştürme metodunun gerçekleştirilmesi.
        public string ConvertToPDF(object content)
        {
            string result;

            // EN: Operations / TR : İşlemler
            // ...

            result = "ExcelToPDF conversion result / ExcelToPDF çevirim işlemi sonucu";

            return result;
        }
    }
}
