using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.ComponentModel;

namespace AFIColor
{
    class ColorsList
    {
        private List<Colors> sList;
        private string ConnectionString;
        public ColorsList()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
               
            sList = new List<Colors>();
            PopList();
        }

        private void reload()
        {
            sList.Clear();
            PopList();
        }


        public void AddColors(Colors Color)
        {
            // Initialize SPROC
            
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPColorInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            
            cmd.Parameters.AddWithValue("@ColorName", Color.ColorName);
            cmd.Parameters.AddWithValue("@ColorNumber", Color.ColorNumber);
            cmd.Parameters.AddWithValue("@ColorManufacturer", Color.ColorManufacturer);
            cmd.Parameters.AddWithValue("@Abrev", Color.Abrev);
            cmd.Parameters.AddWithValue("@PoundsInStock", Color.PoundsInStock);
            cmd.Parameters.AddWithValue("@DesiredPounds", Color.DesiredPounds);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void UpdateColors(Colors Color)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPColorUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@Id", Color.Id);
            cmd.Parameters.AddWithValue("@ColorName", Color.ColorName);
            cmd.Parameters.AddWithValue("@ColorNumber", Color.ColorNumber);
            cmd.Parameters.AddWithValue("@ColorManufacturer", Color.ColorManufacturer);
            cmd.Parameters.AddWithValue("@Abrev", Color.Abrev);
            cmd.Parameters.AddWithValue("@PoundsInStock", Color.PoundsInStock);
            cmd.Parameters.AddWithValue("@DesiredPounds", Color.DesiredPounds);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }
        public void PopList()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPColorSelect", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = null;
            
            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                sList.Add(PopulateColorsFromSqlDataReader(reader));
            }
            conn.Close();
        }

        public static Colors PopulateColorsFromSqlDataReader(SqlDataReader dr)
        {
            Colors colors = new Colors();

            colors.Id = Convert.ToInt32(dr["Id"]);
            colors.ColorName = Convert.ToString(dr["ColorName"]);
            colors.ColorNumber = Convert.ToString(dr["ColorNumber"]);
            colors.ColorManufacturer = Convert.ToString(dr["ColorManufacturer"]);
            colors.Abrev = Convert.ToString(dr["Abrev"]);
            colors.PoundsInStock = Convert.ToString(dr["PoundsInStock"]);
            colors.DesiredPounds = Convert.ToString(dr["DesiredPounds"]);


            return colors;
        }


        public Colors SearchColor(string Abrev)
        {
            foreach (Colors Color in sList)
            {
                if (Color.Abrev == Abrev)
                {
                    return (Color);
                }
            }
            Colors s = new Colors(Abrev);
            return (s);
        }
        public bool ColorExist(string ColorName)
        {
            foreach (Colors Color in sList)
            {
                if (Color.Abrev == ColorName)
                {
                    return (true);
                }
            }
            return (false);
        
        }

        public bool ColorInDB(string AbrevName)
        {
            // Initialize SPROC
			SqlConnection conn = new SqlConnection(ConnectionString);
			SqlCommand cmd = new SqlCommand("SPColorInDB", conn);
			cmd.CommandType = CommandType.StoredProcedure;
            bool rval = false;

			SqlDataReader reader = null;
			Colors shippers = null;

			// GetByID Parameters
            cmd.Parameters.AddWithValue("@AbrevName", AbrevName);

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

        public void DeleteColor(string AbrevName)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPColorDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Delete Parameters
            cmd.Parameters.AddWithValue("@Original_ABREV", AbrevName);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public ArrayList ListColors()
        {
            ArrayList Ta = new ArrayList();
            foreach (Colors Color in sList)
            {
                Ta.Add(Color.Abrev);
            }
            Ta.Sort();
            return Ta;
        }

        public bool AddItem(string Abrev)
        {
            if (ColorExist(Abrev))
            {
                return false;
            }
            else
            {
                Colors s = new Colors(Abrev); 
                sList.Add(s);
                return true;
            }
        }
        public List<Colors> GetColors()
        {
            return sList;
        }

    }
}
