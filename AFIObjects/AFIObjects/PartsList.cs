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
    public class PartsList
    {
        
        private List<Part> pList;
        private string ConnectionString;

        public PartsList()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["AFIShippers.Properties.Settings.AFIDBConnectionString"].ConnectionString;
            pList = new List<Part>();
            PopList();
        }

        private void reload()
        {
            pList.Clear();
            PopList();
        }

        public void AddPart(Part Part)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartsInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            cmd.Parameters.AddWithValue("@PartNo", Part.PartNo);
            cmd.Parameters.AddWithValue("@PartImage", Part.PartImage);
            cmd.Parameters.AddWithValue("@PartDesc", Part.PartDesc);
            cmd.Parameters.AddWithValue("@ColorName", Part.ColorName);
            cmd.Parameters.AddWithValue("@PowderNumber", Part.PowderNumber);
            cmd.Parameters.AddWithValue("@CureTemp", Part.CureTemp);
            cmd.Parameters.AddWithValue("@Millage", Part.Millage);
            cmd.Parameters.AddWithValue("@MinConvSpeed", Part.MinConvSpeed);
            cmd.Parameters.AddWithValue("@MinPiecesPer", Part.MinPiecesPer);
            cmd.Parameters.AddWithValue("@Feet", Part.Feet);
            cmd.Parameters.AddWithValue("@MinPartsPerRack", Part.MinPartsPerRack);
            cmd.Parameters.AddWithValue("@Kv1", Part.Kv1);
            cmd.Parameters.AddWithValue("@FlowRate1", Part.FlowRate1);
            cmd.Parameters.AddWithValue("@Atomizing1", Part.Atomizing1);
            cmd.Parameters.AddWithValue("@Receipe1", Part.Receipe1);
            cmd.Parameters.AddWithValue("@Kv2", Part.Kv2);
            cmd.Parameters.AddWithValue("@FlowRate2", Part.FlowRate2);
            cmd.Parameters.AddWithValue("@Atomizing2", Part.Atomizing2);
            cmd.Parameters.AddWithValue("@Receipe2", Part.Receipe2);
            cmd.Parameters.AddWithValue("@PlugsQty", Part.PlugsQty);
            cmd.Parameters.AddWithValue("@DotsQty", Part.DotsQty);
            cmd.Parameters.AddWithValue("@CapsQty", Part.CapsQty);
            cmd.Parameters.AddWithValue("@SpotFace", Part.SpotFace);
            cmd.Parameters.AddWithValue("@BlowExcessWater", Part.BlowExcessWater);
            cmd.Parameters.AddWithValue("@SpecialNotes", Part.SpecialNotes);
            cmd.Parameters.AddWithValue("@PreMask", Part.PreMask);
            cmd.Parameters.AddWithValue("@MaskTime", Part.MaskTime);
            cmd.Parameters.AddWithValue("@SqFeet", Part.SqFeet);
            cmd.Parameters.AddWithValue("@PaintTime", Part.PaintTime);
            cmd.Parameters.AddWithValue("@PoundsPer", Part.PoundsPer);
            cmd.Parameters.AddWithValue("@Hanger", Part.Hanger);
            cmd.Parameters.AddWithValue("@RackType", Part.RackType);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void UpdatePart(Part Part)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartsUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@Id", Part.Id);
            cmd.Parameters.AddWithValue("@PartNo", Part.PartNo);
            cmd.Parameters.AddWithValue("@PartImage", Part.PartImage);
            cmd.Parameters.AddWithValue("@PartDesc", Part.PartDesc);
            cmd.Parameters.AddWithValue("@ColorName", Part.ColorName);
            cmd.Parameters.AddWithValue("@PowderNumber", Part.PowderNumber);
            cmd.Parameters.AddWithValue("@CureTemp", Part.CureTemp);
            cmd.Parameters.AddWithValue("@Millage", Part.Millage);
            cmd.Parameters.AddWithValue("@MinConvSpeed", Part.MinConvSpeed);
            cmd.Parameters.AddWithValue("@MinPiecesPer", Part.MinPiecesPer);
            cmd.Parameters.AddWithValue("@Feet", Part.Feet);
            cmd.Parameters.AddWithValue("@MinPartsPerRack", Part.MinPartsPerRack);
            cmd.Parameters.AddWithValue("@Kv1", Part.Kv1);
            cmd.Parameters.AddWithValue("@FlowRate1", Part.FlowRate1);
            cmd.Parameters.AddWithValue("@Atomizing1", Part.Atomizing1);
            cmd.Parameters.AddWithValue("@Receipe1", Part.Receipe1);
            cmd.Parameters.AddWithValue("@Kv2", Part.Kv2);
            cmd.Parameters.AddWithValue("@FlowRate2", Part.FlowRate2);
            cmd.Parameters.AddWithValue("@Atomizing2", Part.Atomizing2);
            cmd.Parameters.AddWithValue("@Receipe2", Part.Receipe2);
            cmd.Parameters.AddWithValue("@PlugsQty", Part.PlugsQty);
            cmd.Parameters.AddWithValue("@DotsQty", Part.DotsQty);
            cmd.Parameters.AddWithValue("@CapsQty", Part.CapsQty);
            cmd.Parameters.AddWithValue("@SpotFace", Part.SpotFace);
            cmd.Parameters.AddWithValue("@BlowExcessWater", Part.BlowExcessWater);
            cmd.Parameters.AddWithValue("@SpecialNotes", Part.SpecialNotes);
            cmd.Parameters.AddWithValue("@MaskTime", Part.MaskTime);
            cmd.Parameters.AddWithValue("@SqFeet", Part.SqFeet);
            cmd.Parameters.AddWithValue("@PaintTime", Part.PaintTime);
            cmd.Parameters.AddWithValue("@PreMask", Part.PreMask);
            cmd.Parameters.AddWithValue("@POUNDSPER", Part.PoundsPer);
            cmd.Parameters.AddWithValue("@Hanger", Part.Hanger);
            cmd.Parameters.AddWithValue("@RackType", Part.RackType);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            reload();
        }

        public void DeletePart(int PartID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartsDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Delete Parameters
            cmd.Parameters.AddWithValue("@ID", PartID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            PartsCustLinkDelete(PartID);
            reload();
        }

        public void PopList()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartsSelect", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = null;

            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                pList.Add(PopulatePartFromSqlDataReader(reader));
            }
            conn.Close();
        }

        public static Part PopulatePartFromSqlDataReader(SqlDataReader dr)
        {
            Part part = new Part();

            part.Id = Convert.ToInt32(dr["Id"]);
            part.PartNo = Convert.ToString(dr["PartNo"]);
            part.PartImage = Convert.ToString(dr["PartImage"]);
            part.PartDesc = Convert.ToString(dr["PartDesc"]);
            part.ColorName = Convert.ToString(dr["ColorName"]);
            part.PowderNumber = Convert.ToString(dr["PowderNumber"]);
            part.CureTemp = Convert.ToInt32(dr["CureTemp"]);
            part.Millage = Convert.ToInt32(dr["Millage"]);
            part.MinConvSpeed = Convert.ToInt32(dr["MinConvSpeed"]);
            part.MinPiecesPer = Convert.ToInt32(dr["MinPiecesPer"]);
            part.Feet = Convert.ToInt32(dr["Feet"]);
            part.MinPartsPerRack = Convert.ToInt32(dr["MinPartsPerRack"]);
            part.Kv1 = Convert.ToInt32(dr["Kv1"]);
            part.FlowRate1 = Convert.ToInt32(dr["FlowRate1"]);
            part.Atomizing1 = Convert.ToInt32(dr["Atomizing1"]);
            part.Receipe1 = Convert.ToString(dr["Receipe1"]);
            part.Kv2 = Convert.ToInt32(dr["Kv2"]);
            part.FlowRate2 = Convert.ToInt32(dr["FlowRate2"]);
            part.Atomizing2 = Convert.ToInt32(dr["Atomizing2"]);
            part.Receipe2 = Convert.ToString(dr["Receipe2"]);
            part.PlugsQty = Convert.ToInt32(dr["PlugsQty"]);
            part.DotsQty = Convert.ToInt32(dr["DotsQty"]);
            part.CapsQty = Convert.ToInt32(dr["CapsQty"]);
            part.SpotFace = Convert.ToString(dr["SpotFace"]);
            part.BlowExcessWater = Convert.ToString(dr["BlowExcessWater"]);
            part.SpecialNotes = Convert.ToString(dr["SpecialNotes"]);
            part.PreMask = Convert.ToString(dr["PREMask"]);
            part.MaskTime =  Convert.ToDouble(dr["MASKTIME"]);
            part.SqFeet = Convert.ToDouble(dr["SQFEET"]);
            part.PaintTime = Convert.ToDouble(dr["PAINTTIME"]);
            part.PoundsPer = Convert.ToDouble(dr["POUNDSPER"]);
            part.Hanger = Convert.ToString(dr["HANGER"]);
            part.RackType = Convert.ToString(dr["RACKTYPE"]);
            return part;
        }

        public Part SearchPart(string PartNo)
        {
            foreach (Part part in pList)
            {
                if (part.PartNo == PartNo)
                {
                    return (part);
                }
            }
            Part p = new Part(PartNo);
            return (p);
        }

        public bool PartExists(string PartNo)
        {
            foreach (Part part in pList)
            {
                if (part.PartNo == PartNo)
                {
                    return (true);
                }
            }
            return (false);
        }

        public bool PartInDB(string PartNo)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartInDB", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            bool rval = false;

            SqlDataReader reader = null;

            // GetByID Parameters
            cmd.Parameters.AddWithValue("@PARTNO", PartNo);

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

        public ArrayList ListParts()
        {
            ArrayList Ta = new ArrayList();
            foreach (Part part in pList)
            {
                Ta.Add(part.PartNo);
            }
            Ta.Sort();
            return Ta;
        }

        public bool AddItem(string PartNo)
        {
            if (PartExists(PartNo))
            {
                return false;
            }
            else
            {
                Part p = new Part(PartNo);
                pList.Add(p);
                return true;
            }
        }

        public List<Part> GetParts()
        {
            return pList;
        }

        public ArrayList LoadAssignedCustomers(int partID)
        {

            ArrayList Ta = new ArrayList();
           
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("SPGetPartsCust", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PARTID", SqlDbType.Int).Value = partID;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ta.Add(reader["CUSTSHORTNAME"]);
            }

            reader.Close();
            conn.Close();
            Ta.Sort();
            return (Ta);
        }

        public ArrayList LoadUnAssignedCustomers(int partID)
        {
            ArrayList Ta = new ArrayList();
           
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("SPGetUnusedCust", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PARTID", partID);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Ta.Add(reader["CUSTSHORTNAME"]);
            }
            reader.Close();
            conn.Close();
            Ta.Sort();
            return (Ta);
        }

        
        private int GetCustID(string CustName)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("SPGetCustID", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@parameter1", SqlDbType.VarChar).Value = CustName;
            conn.Open();
            int rval = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rval = int.Parse((reader["ID"]).ToString());
            }
            reader.Close();
            conn.Close();
            return rval;
        }

        private void PartsCustLinkUpdate(int PartID, int CustID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartCustLinkUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@PARTID", PartID);
            cmd.Parameters.AddWithValue("@CUSTID", CustID);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void PartsCustLinkDelete(int PartID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPPartCustLinkDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@PARTID", PartID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void SavePartsCustLink(int PartID, ArrayList CustList)
        {

            PartsCustLinkDelete(PartID);
            foreach (string cust in CustList)
            {
                PartsCustLinkUpdate(PartID, GetCustID(cust));
            }
        }

        public ArrayList GetCustParts(int CustID)
        {
            ArrayList Ta = new ArrayList();

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SPGetCustParts", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.AddWithValue("@CUSTID", CustID);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Ta.Add(reader["PartNO"]);
            }
            reader.Close();
            conn.Close();
            Ta.Sort();
            return (Ta);
        }

    }
}
