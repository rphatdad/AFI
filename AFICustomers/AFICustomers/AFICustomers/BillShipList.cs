using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.ComponentModel;

namespace AFICustomers
{
    
    class BillShipList
    {
        private List<CustBillShip> cList;
        private string ConnectionString;
        private int cID;

        public BillShipList(int CustID)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
            cList = new List<CustBillShip>();
            cID = CustID;
            PopList();
            
        }
        private void reload()
        {
            cList.Clear();
            PopList();
        }

        
        public void AddCustBillShip(CustBillShip CustBS)
        {
            // Initialize SPROC

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPBillShipInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters

            cmd.Parameters.AddWithValue("@ADDRESSNAME", CustBS.AddressName);
            cmd.Parameters.AddWithValue("@ADDRESSTYPE", CustBS.AddressType);
            cmd.Parameters.AddWithValue("@ADDRESS1", CustBS.Address1);
            cmd.Parameters.AddWithValue("@ADDRESS2", CustBS.Address2);
            cmd.Parameters.AddWithValue("@CITY", CustBS.City);
            cmd.Parameters.AddWithValue("@STATE", CustBS.State);
            cmd.Parameters.AddWithValue("@ZIP", CustBS.Zip);
            cmd.Parameters.AddWithValue("@CUSTOMERID", CustBS.CustomerID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void UpdateCustBillShip(CustBillShip CustBS)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPBillShipUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@ADDRESSNAME", CustBS.AddressName);
            cmd.Parameters.AddWithValue("@ADDRESSTYPE", CustBS.AddressType);
            cmd.Parameters.AddWithValue("@ADDRESS1", CustBS.Address1);
            cmd.Parameters.AddWithValue("@ADDRESS2", CustBS.Address2);
            cmd.Parameters.AddWithValue("@CITY", CustBS.City);
            cmd.Parameters.AddWithValue("@STATE", CustBS.State);
            cmd.Parameters.AddWithValue("@ZIP", CustBS.Zip);
            cmd.Parameters.AddWithValue("@CUSTOMERID", CustBS.CustomerID);
            cmd.Parameters.AddWithValue("@ID", CustBS.ID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void PopList()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPBillShipSelect", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CUSTOMERID", cID);
            SqlDataReader reader = null;

            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                cList.Add(PopulateCustBillShipsFromSqlDataReader(reader));
            }
            conn.Close();
        }

        public static CustBillShip PopulateCustBillShipsFromSqlDataReader(SqlDataReader dr)
        {
            CustBillShip custBS = new CustBillShip();

            custBS.ID = Convert.ToInt32(dr["ID"]);
            custBS.CustomerID = Convert.ToInt32(dr["CUSTOMERID"]);
            custBS.AddressName = Convert.ToString(dr["ADDRESSNAME"]);
            custBS.AddressType = Convert.ToString(dr["ADDRESSTYPE"]);
            custBS.Address1 = Convert.ToString(dr["ADDRESS1"]);
            custBS.Address2 = Convert.ToString(dr["ADDRESS2"]);
            custBS.City = Convert.ToString(dr["CITY"]);
            custBS.State = Convert.ToString(dr["STATE"]);
            custBS.Zip = Convert.ToString(dr["ZIP"]);

            return custBS;
        }

        public void DeleteCustBillShip(int ID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPBillShipDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Delete Parameters
            cmd.Parameters.AddWithValue("@ID", ID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }



        public CustBillShip SearchBillShip(string AddName, string AddType)
        {
            foreach (CustBillShip custBS in cList)
            {
                if ((custBS.AddressName == AddName) && (custBS.AddressType == AddType))
                {
                    return (custBS);
                }
            }
            CustBillShip c = new CustBillShip(cID);
            return (c);
        }

        public bool BillShipExists(string AddName, string AddType)
        {
            foreach (CustBillShip custBS in cList)
            {
                if ((custBS.AddressName == AddName) && (custBS.AddressType == AddType))
                {
                    return (true);
                }
            }
            return (false);
        }


        public bool BillShipInDB(string AddName, string AddType)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPBillShipInDB", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            bool rval = false;

            SqlDataReader reader = null;

            // GetByID Parameters
            cmd.Parameters.AddWithValue("@ADDRESSNAME", AddName);
            cmd.Parameters.AddWithValue("@ADDRESSTYPE", AddType);
            // Execute
            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                rval = true;
            }

            conn.Close();


            return rval;

        }

        public bool AddItem(string AddName, string AddType)
        {
            if (BillShipExists(AddName,AddType))
            {
                return false;
            }
            else
            {
                CustBillShip c = new CustBillShip(cID);
                c.AddressName = AddName;
                c.AddressType = AddType;
                cList.Add(c);
                return true;
            }
        }

        public List<CustBillShip> GetCustBillShip()
        {
            return cList;
        }
        public ArrayList ListBilling()
        {
            ArrayList Ta = new ArrayList();
            foreach (CustBillShip Cust in cList)
            {
                if (Cust.AddressType == "Billing")
                {
                    Ta.Add(Cust.AddressName);
                }
            }
            Ta.Sort();
            return Ta;
        }
        public ArrayList ListShipping()
        {
            ArrayList Ta = new ArrayList();
            foreach (CustBillShip Cust in cList)
            {
                if (Cust.AddressType == "Shipping")
                {
                    Ta.Add(Cust.AddressName);
                }
            }
            Ta.Sort();
            return Ta;
        }

    }
}
