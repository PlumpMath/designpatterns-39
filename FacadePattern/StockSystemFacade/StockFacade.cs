using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockSystem;
using System.Common;

namespace StockSystemFacade
{
    //EN : Facade Class for the system / TR : Alt sistem için Facade (Cephe) Sınıfı
    public class StockFacade
    {
        private ProductWorker productWorker;
        private WarehouseWorker warehouseWorker; // TR: Depo

        //EN : Take product out of the warehouse / TR : Ürününün depodan düşülmesi
        public bool TakeProduct(Product product, double amount)
        {
            bool result = false;

            productWorker = new ProductWorker();
            result = productWorker.UpdateAmount(product,amount);

            if (result)
            {
                warehouseWorker = new WarehouseWorker();
                result = warehouseWorker.PrepareOutputReceipt(product, amount);
            }

            return result;
        }
    }
}
