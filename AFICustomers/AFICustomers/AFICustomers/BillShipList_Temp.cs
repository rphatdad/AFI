using System;
using System.Data;


namespace AFICustomers
{
    public class SqlDataProvider
    {

       /* public SqlDataProvider() { }



        public void AddCustBillShip(CustBillShip CustBillShip)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(Globals.ConnectionString);
            SqlCommand cmd = new SqlCommand("AFIColor_CustBillShip_Add", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            cmd.Parameters.Add("@ID", CustBillShip.ID);
            cmd.Parameters.Add("@AddressName", CustBillShip.AddressName);
            cmd.Parameters.Add("@AddressType", CustBillShip.AddressType);
            cmd.Parameters.Add("@Address1", CustBillShip.Address1);
            cmd.Parameters.Add("@Address2", CustBillShip.Address2);
            cmd.Parameters.Add("@City", CustBillShip.City);
            cmd.Parameters.Add("@State", CustBillShip.State);
            cmd.Parameters.Add("@Zip", CustBillShip.Zip);
            cmd.Parameters.Add("@CustomerID", CustBillShip.CustomerID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateCustBillShip(CustBillShip CustBillShip)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(Globals.ConnectionString);
            SqlCommand cmd = new SqlCommand("AFIColor_CustBillShip_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Update Parameters
            cmd.Parameters.Add("@ID", CustBillShip.ID);
            cmd.Parameters.Add("@AddressName", CustBillShip.AddressName);
            cmd.Parameters.Add("@AddressType", CustBillShip.AddressType);
            cmd.Parameters.Add("@Address1", CustBillShip.Address1);
            cmd.Parameters.Add("@Address2", CustBillShip.Address2);
            cmd.Parameters.Add("@City", CustBillShip.City);
            cmd.Parameters.Add("@State", CustBillShip.State);
            cmd.Parameters.Add("@Zip", CustBillShip.Zip);
            cmd.Parameters.Add("@CustomerID", CustBillShip.CustomerID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteCustBillShip(CustBillShip CustBillShipID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(Globals.ConnectionString);
            SqlCommand cmd = new SqlCommand("AFIColor_CustBillShip_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Delete Parameters
            cmd.Parameters.Add("@CustBillShipID", CustBillShipID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public CustBillShip GetCustBillShipByID(CustBillShip CustBillShipID)
        {
            // Initialize SPROC
            SqlConnection conn = new SqlConnection(Globals.ConnectionString);
            SqlCommand cmd = new SqlCommand("AFIColor_CustBillShip_GetByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = null;
            CustBillShip custBillShip = null;

            // GetByID Parameters
            cmd.Parameters.Add("@CustBillShipID", CustBillShipID);

            // Execute
            conn.Open();
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                custBillShip = SqlDataHelpers.PopulateCustBillShipFromSqlDataReader(reader);
            }

            conn.Close();


            return custBillShip;
        }
        public static CustBillShip PopulateCustBillShipFromSqlDataReader(SqlDataReader dr)
        {
            CustBillShip custBillShip = new CustBillShip();

            custBillShip.ID = Convert.ToInt32(dr["ID"]);
            custBillShip.AddressName = Convert.ToString(dr["AddressName"]);
            custBillShip.AddressType = Convert.ToString(dr["AddressType"]);
            custBillShip.Address1 = Convert.ToString(dr["Address1"]);
            custBillShip.Address2 = Convert.ToString(dr["Address2"]);
            custBillShip.City = Convert.ToString(dr["City"]);
            custBillShip.State = Convert.ToString(dr["State"]);
            custBillShip.Zip = Convert.ToString(dr["Zip"]);
            custBillShip.CustomerID = Convert.ToString(dr["CustomerID"]);


            return custBillShip;
        }
        */
    }
}