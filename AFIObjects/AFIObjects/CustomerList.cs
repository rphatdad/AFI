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
    public class CustomerList
    {
        private List<Customer> cList;
        private string ConnectionString;

        public CustomerList()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
            cList = new List<Customer>();
            PopList();
        }

        private void reload()
        {
            cList.Clear();
            PopList();
        }


        public void AddCustomer(Customer Cust)
        {
            // Initialize SPROC

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPCustInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters

            cmd.Parameters.AddWithValue("@CUSTSHORTNAME", Cust.CustShortName );
            cmd.Parameters.AddWithValue("@CUSTNAME", Cust.CustName);
            cmd.Parameters.AddWithValue("@CONTACTNAME",Cust.ContactName);
            cmd.Parameters.AddWithValue("@PHONE1", Cust.Phone1);
            cmd.Parameters.AddWithValue("@PHONE2", Cust.Phone2);
            cmd.Parameters.AddWithValue("@FAX", Cust.Fax );
            cmd.Parameters.AddWithValue("@EMAIL", Cust.Email);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void UpdateCustomer(Customer Cust)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPCustUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@Id", Cust.ID);
            cmd.Parameters.AddWithValue("@CUSTSHORTNAME", Cust.CustShortName);
            cmd.Parameters.AddWithValue("@CUSTNAME", Cust.CustName);
            cmd.Parameters.AddWithValue("@CONTACTNAME", Cust.ContactName);
            cmd.Parameters.AddWithValue("@PHONE1", Cust.Phone1);
            cmd.Parameters.AddWithValue("@PHONE2", Cust.Phone2);
            cmd.Parameters.AddWithValue("@FAX", Cust.Fax);
            cmd.Parameters.AddWithValue("@EMAIL", Cust.Email);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }


        public void PopList()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPCUSTSELECT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = null;

            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                cList.Add(PopulateCustomersFromSqlDataReader(reader));
            }
            conn.Close();
        }

        public static Customer PopulateCustomersFromSqlDataReader(SqlDataReader dr)
        {
            Customer cust = new Customer();

            cust.ID = Convert.ToInt32(dr["ID"]);
            cust.CustShortName = Convert.ToString(dr["CUSTSHORTNAME"]);
            cust.CustName =  Convert.ToString(dr["CUSTNAME"]);
            cust.ContactName =  Convert.ToString(dr["CONTACTNAME"]);
            cust.Phone1 =  Convert.ToString(dr["PHONE1"]);
            cust.Phone2 =  Convert.ToString(dr["PHONE2"]);
            cust.Fax=  Convert.ToString(dr["FAX"]);
            cust.Email =  Convert.ToString(dr["EMAIL"]);
            
            return cust;
        }

        public Customer SearchCustomer(string CShortName)
        {
            foreach (Customer cust in cList)
            {
                if (cust.CustShortName == CShortName)
                {
                    return (cust);
                }
            }
            Customer c = new Customer(CShortName);
            return (c);
        }

        public bool CustExists(string CShortName)
        {
            foreach (Customer cust in cList)
            {
                if (cust.CustShortName == CShortName)
                {
                    return (true);
                }
            }
            return (false);
        }


        public bool CustInDB(string CShortName)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPCustInDB", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            bool rval = false;

            SqlDataReader reader = null;
           
            // GetByID Parameters
            cmd.Parameters.AddWithValue("@CSHORTNAME", CShortName);

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

        public void DeleteCust(string CSHORTNAME)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPCustDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Delete Parameters
            cmd.Parameters.AddWithValue("@Original_CSHORTNAME", CSHORTNAME);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public ArrayList ListCustomers()
        {
            ArrayList Ta = new ArrayList();
            foreach (Customer Cust in cList)
            {
                Ta.Add(Cust.CustShortName);
            }
            Ta.Sort();
            return Ta;
        }

        public bool AddItem(string CShortName)
        {
            if (CustExists(CShortName))
            {
                return false;
            }
            else
            {
                Customer c = new Customer(CShortName);
                cList.Add(c);
                return true;
            }
        }

        public List<Customer> GetCustomers()
        {
            return cList;
        }

    }
}
