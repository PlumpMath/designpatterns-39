using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPSample
{
    public class GraduateStudent : IStudent
    {
        public string AcceptWork()
        {
            return "GraduateStudent - Work was accepted. / Master öğrenci - Görev alındı.";
        }
    }
}
