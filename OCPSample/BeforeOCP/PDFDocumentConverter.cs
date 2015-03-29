using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeforeOCP
{
    class PDFDocumentConverter
    {
        public string Convert(object content,string fileType)
        {
            string result;

            switch (fileType)
            {
                case "WORD" : result = ConvertWordToPDF(content); break;
                case "EXCEL" : result = ConvertExcelToPDF(content); break;
                default: result = "Hata";  break; // EN: Throw Exception / TR : Exception oluşturulabilir.
            }           
            return result;
        }

        //EN : Convert Excel To PDF / TR: Excel den PDF e dönüştürme metodu
        private string ConvertExcelToPDF(object content)
        {
            string result;

            // EN: Operations / TR : İşlemler
            // ...

            result = "ExcelToPDF conversion result / ExcelToPDF çevirim işlemi sonucu";

            return result;
        }

        //EN : Convert Word To PDF / TR: Word den PDF e dönüştürme metodu
        public string ConvertWordToPDF(object content)
        {
            string result;

            // EN: Operations / TR : İşlemler
            // ...

            result = "WordToPDF conversion result / WordToPDF çevirim işlemi sonucu";

            return result;
        }

    }
}
