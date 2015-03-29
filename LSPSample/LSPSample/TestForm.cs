using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSPSample
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Rectangle rectangle;

            try
            {
                rectangle = new Rectangle();
                rectangle.SetParameters(5, 10);

                //EN : Area was calculated. / TR : Alan hesaplandı.
                //EN : LSP is not violated / TR : LSP ihlal edilmedi.
                MessageBox.Show("Area / Alan = " + rectangle.CalculateArea().ToString());

                rectangle = new Square();
                rectangle.SetParameters(5, 10);

                //EN : We do not know if it is square. Area was not calculated. / TR : Kare olduğunu bilmiyoruz. Alan hesaplanmadı.
                //EN : LSP is not violated / TR : LSP ihlal edilmedi.
                MessageBox.Show("Area / Alan = " + rectangle.CalculateArea().ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
