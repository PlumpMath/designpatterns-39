using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Strategy
{
    // EN : There are a group of similar methods - Calculate / TR : Bir grup aynı method vardır. (Hesapla)
    // EN : You can easily extend by adding a new strategy.. (OCP) / TR : Yeni bir strateji ekleyerek, kolaylıkla genişletebilirsiniz.
    public interface ICalculationStrategy
    {
        double Calculate(); // TR : Hesapla
    }
}
