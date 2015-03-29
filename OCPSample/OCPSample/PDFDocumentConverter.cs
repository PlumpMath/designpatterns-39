using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSample
{
    class PDFDocumentConverter
    {
        public string Convert(IPDFConverter fileconverter,object content)
        {
            string result;
            result = fileconverter.ConvertToPDF(content);

            return result;
        }
    }
}
