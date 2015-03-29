using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPSample
{
    public class UnderGraduateStudent : IStudent
    {
        public string AcceptWork()
        {
            return "UnderGraduateStudent - Work was accepted. / Lisans Öğrenci - Görev alındı.";
        }
    }
}
