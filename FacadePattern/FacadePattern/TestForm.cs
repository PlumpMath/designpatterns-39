using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockSystemFacade;
using System.Common;

namespace FacadePattern
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            bool result;
            StockFacade stockFacade = new StockFacade();


            //EN : Assume you have a product class / TR : Bir ürün sınıfının elinize olduğunu düşününüz.
            Product product = new Product();
            product.Id = 1;

            result = stockFacade.TakeProduct(product,1);

            if (result)
                MessageBox.Show(" The operation for taken out the product / Ürünü depodan düşme işlemi.");
            else MessageBox.Show("Unsuccessful operation / İşlem başarısız.");
            
        }
    }
}
