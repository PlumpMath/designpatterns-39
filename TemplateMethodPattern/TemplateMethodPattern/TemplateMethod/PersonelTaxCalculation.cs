using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.TemplateMethod
{
    //EN : Abstract Main class that includes TEmplate Method / TR : Abstract Şablon metodu içeren ana sınıf
    public abstract class PersonnelTaxCalculation
    {
        // EN : first step for template method / TR : Şablon metodun ilk adımı
        // EN : Notice the protected / TR : Protected tanımını fark ediniz.
        protected bool Initialize()
        {

            bool result;

            //Operations / işlemler
            result = true;

            return result;
        }

        // EN : Second step for template method. Note that it is abstract / TR : Şablon metodun ilk adımı. Abstract olduğuna dikkat ediniz.
        protected abstract double CalculateTax();

        // EN : Third step for template method / TR : Şablon metodun 3. adımı
        // EN : Notice the protected / TR : Protected tanımını fark ediniz.
        protected bool Save()
        {

            bool result;

            //Operations / işlemler
            result = true;

            return result;
        }

        //EN:TEmplate Method / TR : Şablon metod
        public double GetTax()
        {

            double taxResult;
            bool result = false;

            result = Initialize();
            
            taxResult = CalculateTax(); //EN : Will be provided by inherited member / TR : türetilmiş sınıf tarafından sağlanacaktır.
            
            result = Save();

            return taxResult;
        }
    }
}
