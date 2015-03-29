using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISRSample
{
    // EN : We have used the ready interface. All methods will be realized.
    // TR : Hazır olan bir arayüzü kullandık. Tüm metodlar gerçekleştirilebilecektir.
    class AcademicPerson : IAcademicServices, IPersonServices
    {
        public void TakeFoodService()
        {
            // EN : Can realize the method / TR : Metodu gerçekleştirebilir.
        }

        public void TakeTransportService()
        {
            // EN : Can realize the method / TR : Metodu gerçekleştirebilir.
        }

        public void AccessToAcademicResources()
        {
            // EN : Can realize the method / TR : Metodu gerçekleştirebilir.
        }

        public void JoinCongress()
        {
            // EN : Can realize the method / TR : Metodu gerçekleştirebilir.
        }
    }
}
