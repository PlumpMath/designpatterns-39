using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StrategyPattern.Strategy;

namespace StrategyPattern
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //EN : Decide to one of the strategies / TR : Stratejilerden birisine karar verilir. 
            //EN : You can use Factory method to select one of the strategies 
            // TR : Stratejilerden birisini seçmek için, fabrika metodu kullanabilirsiniz.

            ICalculationStrategy strategy = new StrategyB(); // EN : We have decided With simple method / TR : Basit metod ile karar verdik.
            CompanyContext context = new CompanyContext(strategy);

            MessageBox.Show(" Result / Sonuç = " + context.Calculate().ToString());
        }
    }
}
