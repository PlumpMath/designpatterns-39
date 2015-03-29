using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeforeSRP
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is no code for execution. Look at class documentation / Çalıştırmak için kod yok. Sınıf dökümantasyonuna bakınız.");
        }
    }
}
