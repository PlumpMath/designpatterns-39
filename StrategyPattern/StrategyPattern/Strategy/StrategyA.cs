using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Strategy
{
    public class StrategyA : ICalculationStrategy
    {
        //EN : Strategy class in the family / TR : Ailede bir strateji sınıfı.
        public double Calculate()
        {
            double result = 0.0;

            //EN : Operations for this calculation / TR : Bu hesaplama için işlemler

            result = 100;

            return result;
        }
    }
}
