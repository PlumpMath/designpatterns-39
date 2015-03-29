using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.Common;
using BCargoIntegration;

namespace AdapterPattern.Adapters
{
    //EN : Cargo Adapter for Company B / TR : B kargo firması için, Kargo adaptörü
    public class BCargoAdapter : ICargoOperations
    {
        private BCargoAdaptee cargoAdaptee; // EN : The class that will be adapted / TR : Adapte edilecek sınıf

        public BCargoAdapter()
        {
            cargoAdaptee = new BCargoAdaptee();
        }

        public bool SendCargo(Cargo cargo)
        {
            bool result;

            result = cargoAdaptee.AcceptCargo(cargo.Id.ToString(), cargo.Name, cargo.CustomerAdress, cargo.CustomerPhone);

            return result;
        }
    }
}
