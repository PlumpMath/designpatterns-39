using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Strategy
{
    //EN : Context class that the client will access / TR : İstemcinin erişeceği durum sınıfı
    public class CompanyContext
    {
        ICalculationStrategy defaultStrategy;

        // EN : CompanyContext gets the strategy from the external world. / TR : CompanyContext sınıfı, stratejiyi dışarıdan alır.
        // EN : You can also decide which strategy to select inside the CompanyContext by controlling a parameter value. 
        // TR : Bir parametre değerini kontrol ederek, CompanyContext sınıfı içinde hangi stratejiyi seçeceğinize karar verebilirsiniz.

        // EN : We talk to the Context class, it delegates the call to the appropriate strategy 
        // TR : Biz, coontext sınıfına erişiriz. Bu sınıf, uygun olan strateji nesnesine yönlendirir.
        public CompanyContext(ICalculationStrategy strategy)
        {
            defaultStrategy = strategy;
        }

        public double Calculate()
        {
            return defaultStrategy.Calculate();
        }
    }
}
