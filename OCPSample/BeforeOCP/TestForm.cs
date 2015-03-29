using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeforeOCP
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            PDFDocumentConverter converter = new PDFDocumentConverter();            
            object content = "Document"; // EN: Content of the file / TR : Dokümanın içeriği

            MessageBox.Show(converter.Convert(content,"EXCEL"));
        }
    }
}
