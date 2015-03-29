using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FactoryMethodPattern.FactoryMethod;

namespace FactoryMethodPattern
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string logProviderType;
            ILogProvider logProvider;
            bool logResult = false;

            //EN : The log provider type may come from a configuration file or DB / TR : Log kaynağı tipi, bir konfigürasyon dosyasından veya veritabanından gelebilir.
            //EN : Simply, assing a value / TR : Basit olarak, bir değer verelim.

            logProviderType = "DB"; // Or "FILE"
            logProvider = LogProviderFactory.GetNewLogProvider(logProviderType);

            logResult = logProvider.LogItem("Test Data");

            if (logResult)
                MessageBox.Show(" LogItem method has been executed. / LogItem metodu çalıştırıldı.");

        }
    }
}
