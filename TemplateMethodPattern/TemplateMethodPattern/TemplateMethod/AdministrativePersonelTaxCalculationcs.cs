using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern.TemplateMethod
{
    public class AdministrativePersonelTaxCalculationcs : PersonnelTaxCalculation
    {
        protected override double CalculateTax()
        {
            double taxResult = 0.0;

            //Operations / İşlemler

            taxResult = 200;

            return taxResult;
        }
    }
}
