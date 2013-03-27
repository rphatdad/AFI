using System;
using System.Collections.Generic;
using System.Text;

namespace AFIObjects
{
    public class ShipTotals
    {
        private int initRcvQty;
        private int shippedQty;
        private int onHandQty;
        private int backOrderQty;
       
        public ShipTotals()
        {
            initRcvQty = 0;
            shippedQty = 0;
            onHandQty = 0;
            backOrderQty = 0;
        }

        public void AddPO(PO po)
        {
            initRcvQty += po.InitialQty;
            shippedQty += po.ShippedQty;
            onHandQty += po.InventoryQty;
            backOrderQty += po.OnHandQty;
        }

        public int InitRcvQty
        {
            get { return initRcvQty; }
            set { initRcvQty = value; }
        }
        public int ShippedQty
        {
            get { return shippedQty; }
            set { shippedQty = value; }
        }
        public int OnHandQty
        {
            get { return onHandQty; }
            set { onHandQty = value; }
        }
        public int BackOrderQty
        {
            get { return backOrderQty; }
            set { backOrderQty = value; }
        }
        
    }
}
