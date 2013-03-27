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
    public class PartMaskLinkList
    {
        private List<PartMaskLink> pList;
        private string ConnectionString;
        private int FilterID;

        public PartMaskLinkList()
        {
            FilterID = 0;
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
            pList = new List<PartMaskLink>();
            PopList();
        }
        public PartMaskLinkList(int PartID)
        {
            FilterID = PartID;
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
            pList = new List<PartMaskLink>();
            PopList();
        }

        public void reload()
        {
            pList.Clear();
            PopList();
        }

        public void PopList()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd;
            if (FilterID == 0)
            {
                cmd = new SqlCommand("SPPartMaskLinkSelect", conn);
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd = new SqlCommand("SPPartMaskLinkSelectByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PARTID", FilterID);
            }
            SqlDataReader reader = null;
            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                pList.Add(PopulatePartMaskLinkFromSqlDataReader(reader));
            }
            conn.Close();
        }



        public void AddPartMaskLink(PartMaskLink PartMaskLink)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartMaskLinkInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            cmd.Parameters.AddWithValue("@PartNumber", PartMaskLink.PartNumber);
            cmd.Parameters.AddWithValue("@PartID", PartMaskLink.PartID);
            cmd.Parameters.AddWithValue("@MaskDescription", PartMaskLink.MaskDescription);
            cmd.Parameters.AddWithValue("@MaskType", PartMaskLink.MaskType);
            cmd.Parameters.AddWithValue("@MaskQty", PartMaskLink.MaskQty);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdatePartMaskLink(PartMaskLink PartMaskLink)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartMaskLinkUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@LinkID", PartMaskLink.LinkID);
            cmd.Parameters.AddWithValue("@PartNumber", PartMaskLink.PartNumber);
            cmd.Parameters.AddWithValue("@PartID", PartMaskLink.PartID);
            cmd.Parameters.AddWithValue("@MaskDescription", PartMaskLink.MaskDescription);
            cmd.Parameters.AddWithValue("@MaskType", PartMaskLink.MaskType);
            cmd.Parameters.AddWithValue("@MaskQty", PartMaskLink.MaskQty);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeletePartMaskLink(PartMaskLink PartMaskLinkID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartMaskLinkDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Delete Parameters
            cmd.Parameters.AddWithValue("@LINKID", PartMaskLinkID.LinkID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
        public static PartMaskLink PopulatePartMaskLinkFromSqlDataReader(SqlDataReader dr)
        {
            PartMaskLink partMaskLink = new PartMaskLink();

            partMaskLink.LinkID = Convert.ToInt32(dr["LinkID"]);
            partMaskLink.PartNumber = Convert.ToString(dr["PartNumber"]);
            partMaskLink.PartID = Convert.ToInt32(dr["PartID"]);
            partMaskLink.MaskDescription = Convert.ToString(dr["MaskDescription"]);
            partMaskLink.MaskType = Convert.ToString(dr["MaskType"]);
            partMaskLink.MaskQty = Convert.ToInt32(dr["MaskQty"]);

            return partMaskLink;
        }
        public PartMaskLink SearchPartMaskLink(String Desc, String Type)
        {
            foreach (PartMaskLink p in pList)
            {
                if ((p.MaskDescription == Desc)&&(p.MaskType == Type))
                {
                    return p;
                }
            }
            PartMaskLink pml = new PartMaskLink();
            return (pml);
        }


        public int GetMaskTotal(String Type)
        {
            int MaskTotal = 0;
            foreach (PartMaskLink p in pList)
            {
                if (p.MaskType == Type)
                {
                    MaskTotal += p.MaskQty;
                }
            }
            return MaskTotal;
        }

        public bool PartMaskLinkExist(String Desc, String Type)
        {
            foreach (PartMaskLink p in pList)
            {
                if ((p.MaskDescription == Desc)&&(p.MaskType == Type))
                {
                    return true;
                }
            }
            return (false);

        }

        public List<PartMaskLink> GetPartMaskLink()
        {
            return pList;
        }

    }
}
