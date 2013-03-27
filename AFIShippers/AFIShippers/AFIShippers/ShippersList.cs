using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.ComponentModel;

namespace AFIShippers
{
    class ShippersList
    {
        private List<Shippers> sList;
        private string ConnectionString;
        public ShippersList()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
               
            sList = new List<Shippers>();
            PopList();
        }

        private void reload()
        {
            sList.Clear();
            PopList();
        }

        public void AddShippers(Shippers Shippers)
        {
            // Initialize SPROC
            
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPShippersInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            cmd.Parameters.AddWithValue("@ID", 0);
            cmd.Parameters.AddWithValue("@Shipper", Shippers.Shipper);
            cmd.Parameters.AddWithValue("@Phone", Shippers.Phone);
            cmd.Parameters.AddWithValue("@Fax", Shippers.Fax);
            cmd.Parameters.AddWithValue("@Comments", Shippers.Comments);
            cmd.Parameters.AddWithValue("@Cell", Shippers.Cell);
            cmd.Parameters.AddWithValue("@Other", Shippers.Other);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void UpdateShippers(Shippers Shippers)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPShippersUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@ID", 0);
            cmd.Parameters.AddWithValue("@Shipper", Shippers.Shipper);
            cmd.Parameters.AddWithValue("@Phone", Shippers.Phone);
            cmd.Parameters.AddWithValue("@Fax", Shippers.Fax);
            cmd.Parameters.AddWithValue("@Comments", Shippers.Comments);
            cmd.Parameters.AddWithValue("@Cell", Shippers.Cell);
            cmd.Parameters.AddWithValue("@Other", Shippers.Other);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }
        public void PopList()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPShippersSelect", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = null;
            
            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                sList.Add(PopulateShippersFromSqlDataReader(reader));
            }
            conn.Close();
        }

        public static Shippers PopulateShippersFromSqlDataReader(SqlDataReader dr)
        {
            Shippers shippers = new Shippers();

            shippers.ID = Convert.ToInt32(dr["ID"]);
            shippers.Shipper = Convert.ToString(dr["Shipper"]);
            shippers.Phone = Convert.ToString(dr["Phone"]);
            shippers.Fax = Convert.ToString(dr["Fax"]);
            shippers.Comments = Convert.ToString(dr["Comments"]);
            shippers.Cell = Convert.ToString(dr["Cell"]);
            shippers.Other = Convert.ToString(dr["Other"]);


            return shippers;
        }

        public Shippers SearchShipper(string ShipperName)
        {
            foreach (Shippers Ship in sList)
            {
                if (Ship.Shipper == ShipperName)
                {
                    return Ship;
                }
            }
            Shippers s = new Shippers(ShipperName);
            return (s);
        }
        public bool ShipperExist(string ShipperName)
        {
            foreach (Shippers Ship in sList)
            {
                if (Ship.Shipper == ShipperName)
                {
                    return true;
                }
            }
            return (false);
        
        }

        public bool ShipperInDB(string ShipperName)
        {
            // Initialize SPROC
			SqlConnection conn = new SqlConnection(ConnectionString);
			SqlCommand cmd = new SqlCommand("SPShippersInDB", conn);
			cmd.CommandType = CommandType.StoredProcedure;
            bool rval = false;

			SqlDataReader reader = null;
			Shippers shippers = null;

			// GetByID Parameters
			cmd.Parameters.AddWithValue("@ShipName", ShipperName);

			// Execute
			conn.Open();
			reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

			if(reader.Read())
			{
				rval = true;
			}

			conn.Close();


			return rval;

        }
        public void DeleteShipper(string ShipperName)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPShippersDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Delete Parameters
            cmd.Parameters.AddWithValue("@Original_Shipper", ShipperName);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public ArrayList ListShippers()
        {
            ArrayList Ta = new ArrayList();
            foreach (Shippers Ship in sList)
            {
                Ta.Add(Ship.Shipper);
            }
            Ta.Sort();
            return Ta;
        }

        public bool AddItem(string ShipName)
        {
            if (ShipperExist(ShipName))
            {
                return false;
            }
            else
            {
                Shippers s = new Shippers(ShipName); 
                sList.Add(s);
                return true;
            }
        }
        public List<Shippers> GetShippers()
        {
            return sList;
        }

    }
}
