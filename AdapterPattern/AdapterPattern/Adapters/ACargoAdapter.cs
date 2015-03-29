using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACargoIntegration;
using AdapterPattern.Common;

namespace AdapterPattern.Adapters
{
    //EN : Cargo Adapter for Company A / TR : A kargo firması için, Kargo adaptörü
    public class ACargoAdapter : ICargoOperations
    {
        private ACargoAdaptee cargoAdaptee; // EN : The class that will be adapted / TR : Adapte edilecek sınıf
        
        public ACargoAdapter()
        {
            cargoAdaptee = new ACargoAdaptee();
        }
        
        public bool SendCargo(Cargo cargo)
        {
            bool result;

            result = cargoAdaptee.AcceptCargo(cargo.Id.ToString(), cargo.Name, cargo.CustomerAdress, cargo.CustomerPhone, cargo.CustomerIDNumber);

            return result;
        }
    }
}
