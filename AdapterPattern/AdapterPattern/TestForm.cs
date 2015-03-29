using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdapterPattern.Adapters;
using AdapterPattern.Common;

namespace AdapterPattern
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
            //EN : Select a cargoCampany / TR : Kargo firması seçilir.
            ICargoOperations cargoCampany = new BCargoAdapter();
            CargoManager cargoManager = new CargoManager(cargoCampany);

            //EN : Cargo information / TR : Kargo bilgileri
            Cargo cargo = new Cargo();

            cargo.Id = 1;
            cargo.CustomerPhone = "0 555 555 55 55";
            cargo.Name = "Deneme";
            cargo.CustomerAdress = "Fatih Üniversitesi / University";
            cargo.CustomerIDNumber = "1111111111111";

            result = cargoManager.SendCargo(cargo);

            if (result)
                MessageBox.Show("Cargo deliver / Kargo Teslim");
            else MessageBox.Show("Cargo problem / Kargo problem");

        }
    }
}
