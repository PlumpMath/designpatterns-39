using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.Common;

namespace AdapterPattern
{
    public interface ICargoOperations
    {
        bool SendCargo(Cargo cargo);
    }
}
