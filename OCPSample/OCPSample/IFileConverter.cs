using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSample
{
    interface IPDFConverter
    {
        // TR: PDF'e dönüştürme metodu.
        string ConvertToPDF(object content);
    }
}
