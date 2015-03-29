using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Strategy
{
    public class StrategyB : ICalculationStrategy
    {
        //EN : Another strategy class in the family / TR : Ailede diğer bir strateji sınıfı.
        public double Calculate()
        {
            double result = 0.0;

            //EN : Operations for this calculation / TR : Bu hesaplama için işlemler

            result = 200;

            return result;
        }
    }
}
