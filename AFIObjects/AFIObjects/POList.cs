using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using System.Windows.Forms;
using System.ComponentModel;
namespace AFIObjects
{
    public class POList
    {
        private List<PO> pList;
        private string ConnectionString;
        private string filter;

        public POList()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
            pList = new List<PO>();
            filter = "";
            PopList();   
        }

        public POList(string afilter)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
            pList = new List<PO>();
            filter = afilter;
            PopList();
        }

        private void AddFilter(string afilter)
        {
            filter = afilter;
            reload();
        }

        private void reload()
        {
            pList.Clear();
            PopList();
        }

        public void AddPO(PO PO)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPOInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            cmd.Parameters.AddWithValue("@PoNumber", PO.PoNumber);
            cmd.Parameters.AddWithValue("@CustomerID", PO.CustomerID);
            cmd.Parameters.AddWithValue("@PartNumber", PO.PartNumber);
            cmd.Parameters.AddWithValue("@TrackingNumber", PO.TrackingNumber);
            cmd.Parameters.AddWithValue("@ReceiveDate", PO.ReceiveDate);
            cmd.Parameters.AddWithValue("@HotPart", PO.HotPart);
            cmd.Parameters.AddWithValue("@Color", PO.Color);
            cmd.Parameters.AddWithValue("@Comments", PO.Comments);
            cmd.Parameters.AddWithValue("@InitialQty", PO.InitialQty);
            cmd.Parameters.AddWithValue("@OnHandQty", PO.OnHandQty);
            cmd.Parameters.AddWithValue("@InventoryQty", PO.InventoryQty);
            cmd.Parameters.AddWithValue("@FabRejectQty", PO.FabRejectQty);
            cmd.Parameters.AddWithValue("@PaintRejectQty", PO.PaintRejectQty);
            cmd.Parameters.AddWithValue("@POStatus", PO.POStatus);
            cmd.Parameters.AddWithValue("@RcvComment", PO.RcvComment);
            cmd.Parameters.AddWithValue("@InvComment", PO.InvComment);
            cmd.Parameters.AddWithValue("@ShipComment", PO.ShipComment);
            cmd.Parameters.AddWithValue("@ShipTo", PO.ShipTo);
            cmd.Parameters.AddWithValue("@BillTo", PO.BillTo);
            cmd.Parameters.AddWithValue("@ShippedQty", PO.ShippedQty);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void ShipPO(String PONum, int CustID, string PartNo, 
            string RcvDate, string TrackingNumber, string ShipComment, int ShippedQuan, int Shipto, 
            int Inventory, int OnHand, string POStat, int Billto)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("SPSHIPPOUpdate", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PONUMBER", PONum);
            command.Parameters.AddWithValue("@CUSTOMERID", CustID);
            command.Parameters.AddWithValue("@PARTNUMBER", PartNo);
            command.Parameters.AddWithValue("@RECEIVEDATE", RcvDate);
            command.Parameters.AddWithValue("@TRACKINGNUMBER", TrackingNumber);
            command.Parameters.AddWithValue("@SHIPCOMMENT", ShipComment);
            command.Parameters.AddWithValue("@SHIPPEDQTY", ShippedQuan);
            command.Parameters.AddWithValue("@INVENTORY", Inventory);
            command.Parameters.AddWithValue("@AVAIL", OnHand);
            command.Parameters.AddWithValue("@POSTAT", POStat);
            command.Parameters.AddWithValue("@SHIPTO", Shipto);
            command.Parameters.AddWithValue("@BILLTO", Billto);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void CreateShipmentRecord(int CustID,string PartNumber,int QtyShipped,
                                         int PoID, string TrackingNumber,int Shipto,int Billto, int ShippedVia)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("SPPARTSHIPLINK", conn);
            command.CommandType = CommandType.StoredProcedure;
           
            command.Parameters.AddWithValue("@CUSTID", CustID);
            command.Parameters.AddWithValue("@PARTNUMBER", PartNumber);
            command.Parameters.AddWithValue("@QTYSHIPPED", QtyShipped);
            command.Parameters.AddWithValue("@POID", PoID);
            command.Parameters.AddWithValue("@TRACKINGNUMBER", TrackingNumber);
            command.Parameters.AddWithValue("@SHIPTO", Shipto);
            command.Parameters.AddWithValue("@BILLTO", Billto);
            command.Parameters.AddWithValue("@SHIPPEDVIA", ShippedVia);
            
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
   

        public void UpdatePO(PO PO)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPOUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@Id", PO.Id);
            cmd.Parameters.AddWithValue("@PoNumber", PO.PoNumber);
            cmd.Parameters.AddWithValue("@CustomerID", PO.CustomerID);
            cmd.Parameters.AddWithValue("@PartNumber", PO.PartNumber);
            cmd.Parameters.AddWithValue("@TrackingNumber", PO.TrackingNumber);
            cmd.Parameters.AddWithValue("@ReceiveDate", PO.ReceiveDate);
            cmd.Parameters.AddWithValue("@HotPart", PO.HotPart);
            cmd.Parameters.AddWithValue("@Color", PO.Color);
            cmd.Parameters.AddWithValue("@Comments", PO.Comments);
            cmd.Parameters.AddWithValue("@InitialQty", PO.InitialQty);
            cmd.Parameters.AddWithValue("@OnHandQty", PO.OnHandQty);
            cmd.Parameters.AddWithValue("@InventoryQty", PO.InventoryQty);
            cmd.Parameters.AddWithValue("@FabRejectQty", PO.FabRejectQty);
            cmd.Parameters.AddWithValue("@PaintRejectQty", PO.PaintRejectQty);
            cmd.Parameters.AddWithValue("@ShippedQty", PO.ShippedQty);
            cmd.Parameters.AddWithValue("@POStatus", PO.POStatus);
            cmd.Parameters.AddWithValue("@RcvComment", PO.RcvComment);
            cmd.Parameters.AddWithValue("@InvComment", PO.InvComment);
            cmd.Parameters.AddWithValue("@ShipComment", PO.ShipComment);
            cmd.Parameters.AddWithValue("@ShipTo", PO.ShipTo);
            cmd.Parameters.AddWithValue("@BillTo", PO.BillTo);
            if (PO.CloseDate == null)
            {
                cmd.Parameters.AddWithValue("@CloseDate", System.DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@CloseDate", PO.CloseDate);
            }
            if (PO.LastShipDate == null)
            {
                cmd.Parameters.AddWithValue("@LastShipDate", System.DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@LastShipDate", PO.LastShipDate);
            }
            cmd.Parameters.AddWithValue("@DaysAtAFI", PO.GetDaysatAFI());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void DeletePO(int POID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPODelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Delete Parameters
            cmd.Parameters.AddWithValue("@POID", POID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }


        public void PopList()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd;
            if (filter != "")
            {
                cmd = new SqlCommand("SPPOFilteredSelect", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FILTER", filter);
            }
            else
            {
                cmd = new SqlCommand("SPPOSelect", conn);
                cmd.CommandType = CommandType.StoredProcedure;
            }
           
            SqlDataReader reader = null;

            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                pList.Add(PopulatePOFromSqlDataReader(reader));
            }
            conn.Close();
        }


        public PO GetPOByID(PO POID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPGETPOID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = null;
            PO pO = null;

            // GetByID Parameters
            cmd.Parameters.AddWithValue("@POID", POID);

            // Execute
            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                pO = PopulatePOFromSqlDataReader(reader);
            }

            conn.Close();


            return pO;
        }
        public static PO PopulatePOFromSqlDataReader(SqlDataReader dr)
        {
            PO pO = new PO();

            pO.Id = Convert.ToInt32(dr["Id"]);
            pO.PoNumber = Convert.ToString(dr["PoNumber"]);
            pO.CustomerID = Convert.ToInt32(dr["CustomerID"]);
            pO.PartNumber = Convert.ToString(dr["PartNumber"]);
            pO.TrackingNumber = Convert.ToString(dr["TrackingNumber"]);
            pO.ReceiveDate = Convert.ToDateTime(dr["ReceiveDate"]);
            pO.HotPart = Convert.ToString(dr["HotPart"]);
            pO.Color = Convert.ToString(dr["Color"]);
            pO.Comments = Convert.ToString(dr["Comments"]);
            pO.InitialQty = Convert.ToInt32(dr["InitialQty"]);
            pO.OnHandQty = Convert.ToInt32(dr["OnHandQty"]);
            pO.InventoryQty = Convert.ToInt32(dr["InventoryQty"]);
            pO.FabRejectQty = Convert.ToInt32(dr["FabRejectQty"]);
            pO.PaintRejectQty = Convert.ToInt32(dr["PaintRejectQty"]);
            pO.ShippedQty = Convert.ToInt32(dr["ShippedQty"]);
            pO.POStatus = Convert.ToString(dr["POStatus"]);
            pO.RcvComment = Convert.ToString(dr["RcvComment"]);
            pO.InvComment = Convert.ToString(dr["InvComment"]);
            pO.ShipComment = Convert.ToString(dr["ShipComment"]);
            pO.ShipTo = Convert.ToInt32(dr["ShipTo"]);
            pO.BillTo = Convert.ToInt32(dr["BillTo"]);
            if (dr["CloseDate"] != System.DBNull.Value)
            {
                pO.CloseDate = Convert.ToDateTime(dr["CloseDate"]);
            }
            if (dr["LastShipDate"] != System.DBNull.Value)
            {
                pO.LastShipDate = Convert.ToDateTime(dr["LastShipDate"]);
            }
            return pO;
        }

        public ArrayList ListPOs()
        {
            ArrayList Ta = new ArrayList();
            foreach (PO po in pList)
            {
                Ta.Add(po.PoNumber);
            }
            Ta.Sort();
            return Ta;
        }

        public List<PO> GetPOs()
        {
            return pList;
        }

        public List<PO> GetMatchingPOs(int CustID, string PartNum)
        {
            List<PO> tList =  new List<PO>();
            foreach (PO po in pList)
            {
                if ((po.CustomerID == CustID) && (po.PartNumber == PartNum) )
                {
                    tList.Add(po);
                }
            }
            return tList;
        }
        public PO FindPO(int CustID, string PartNum, DateTime rcv, string PONum)
        {
            foreach (PO po in pList)
            {
                if ((po.CustomerID == CustID ) && (po.PartNumber == PartNum))
                {
                    if (po.ReceiveDate.ToString() == rcv.ToString())
                    {
                        return po;
                    }
                }
            }
            return null;
        }

        public void UpdatePOInv(String PONum, int CustID, string PartNo, 
            string RcvDate, string InvComments, int InvQuan, int FabR, 
            int PaintR, int OnHand, string POStat)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("SPINVPOUpdate", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PONUMBER", PONum);
            command.Parameters.AddWithValue("@CUSTOMERID", CustID);
            command.Parameters.AddWithValue("@PARTNUMBER", PartNo);
            command.Parameters.AddWithValue("@RECEIVEDATE", RcvDate);
            command.Parameters.AddWithValue("@INVCOMMENTS", InvComments);
            command.Parameters.AddWithValue("@INVQTY", InvQuan);
            command.Parameters.AddWithValue("@FABR", FabR);
            command.Parameters.AddWithValue("@PAINTR", PaintR);
            command.Parameters.AddWithValue("@AVAIL", OnHand);
            command.Parameters.AddWithValue("@POSTAT", POStat);
          
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
