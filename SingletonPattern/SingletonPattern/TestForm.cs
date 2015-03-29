using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //EN : Without using New Operator, access the object / TR : New operatörünü kullanmadan, nesneye erişim.
            //EN : Every time access the same instance / TR : Her zaman aynı örneğe erişilecektir.

            string parameterA = MyConfigurationManager.Instance.ParameterA;
            int parameterB = MyConfigurationManager.Instance.ParameterB;

            // MyConfigurationManager.Instance.ParameterA = "Test"; // EN: This line can not be executed because of signing as private. TR : Bu satır çalıştırılamayacak. Çünkü, dışarıdan erişime kapatılmıştır.

            MessageBox.Show("Parameter A = " + parameterA);
            MessageBox.Show("Parameter B = " + parameterB.ToString());

            MyConfigurationManager firstInstance = MyConfigurationManager.Instance;
            MyConfigurationManager secondInstance = MyConfigurationManager.Instance;

            if (firstInstance == secondInstance)
                MessageBox.Show("They are the same objects / Onlar aynı nesnelerdir.");

        }
    }
}
