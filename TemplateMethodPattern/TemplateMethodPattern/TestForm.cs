using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TemplateMethodPattern.TemplateMethod;

namespace TemplateMethodPattern
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            double taxResult = 0.0;

            PersonnelTaxCalculation taxCalculation = new AcademicPersonelTaxCalculation();
            taxResult = taxCalculation.GetTax();
            
            MessageBox.Show("Tax Result/Vergi sonucu = " + taxResult.ToString());
        }
    }
}
