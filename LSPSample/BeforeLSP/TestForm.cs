using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeforeLSP
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Square();

            rectangle.SetHeight(5);
            rectangle.SetWidth(10);

            //EN : Result must be 50. But... / TR : Sonuç 50 olmalı. Fakat...
            //EN : LSP violated / TR : LSP ihlal edildi.
            MessageBox.Show("Area / Alan = " + rectangle.CalculateArea().ToString());
        }
    }
}
