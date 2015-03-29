using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISRSample
{
    // EN : We have used the ready interface. But there are methods which can not be realized. 
    // TR : Hazır olan bir arayüzü kullandık. Ama, gerçekleştiremiyeceğimiz metodlar var.
    class AdministrativePerson : IPersonServices
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
            // EN : Can not realize the method / TR : Metodu gerçekleştiremez.
        }

        public void JoinCongress()
        {
            // EN : Can not realize the method / TR : Metodu gerçekleştiremez.
        }
    }
}
