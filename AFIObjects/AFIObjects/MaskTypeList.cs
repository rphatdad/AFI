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
    public class MaskTypeList
    {

        private List<MaskType> mList;
        private string ConnectionString;

        public MaskTypeList()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
            mList = new List<MaskType>();
            PopList();
        }

        private void reload()
        {
            mList.Clear();
            PopList();
        }

        public void PopList()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPMaskTypeSelect", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = null;

            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                mList.Add(PopulateMaskTypeFromSqlDataReader(reader));
            }
            conn.Close();
        }

        public void AddMaskType(MaskType MaskType)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPMaskTypeInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            cmd.Parameters.AddWithValue("@Type", MaskType.Type);
            cmd.Parameters.AddWithValue("@Description", MaskType.Description);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void UpdateMaskType(MaskType MaskType)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPMaskTypeUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@ID", MaskType.ID);
            cmd.Parameters.AddWithValue("@Type", MaskType.Type);
            cmd.Parameters.AddWithValue("@Description", MaskType.Description);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void DeleteMaskType(int MaskTypeID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPMaskTypeDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Delete Parameters
            cmd.Parameters.AddWithValue("@ID", MaskTypeID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        

        public static MaskType PopulateMaskTypeFromSqlDataReader(SqlDataReader dr)
        {
            MaskType maskType = new MaskType();

            maskType.ID = Convert.ToInt32(dr["ID"]);
            maskType.Type = Convert.ToString(dr["Type"]);
            maskType.Description = Convert.ToString(dr["Description"]);


            return maskType;
        }
        public List<MaskType> GetAllMask()
        {
            reload();
            return mList;
        }

        public ArrayList GetMaskbyType(string sType)
        {
            ArrayList Ta = new ArrayList();
            foreach (MaskType MT in mList)
            {
                if (MT.Type.Equals(sType))
                {
                    Ta.Add(MT.Description);
                }
            }
            Ta.Sort();
            if (Ta.Count == 0)
            {
                Ta.Add("");
            }
            return Ta;
        }
    }
}
