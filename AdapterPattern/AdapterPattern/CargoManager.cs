using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.Common;

namespace AdapterPattern
{
    public class CargoManager
    {
        ICargoOperations cargoCompany;
        //EN : Constructor / TR : Nesne oluşturulduğunda çalışna ilk metod.
        public CargoManager(ICargoOperations selectedCargoCompany)
        {
            cargoCompany = selectedCargoCompany;
        }
        public bool SendCargo(Cargo cargo)
        {
            bool result;

            result = cargoCompany.SendCargo(cargo);

            return result;
        }
    }
}
