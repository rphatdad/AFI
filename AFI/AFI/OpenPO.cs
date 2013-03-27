using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AFI
{
    public class OpenPO
    {
        private string poNumber;

        public string PoNumber
        {
            get { return poNumber; }
            set { poNumber = value; }
        }
        private string trackingNumber;

        public string TrackingNumber
        {
            get { return trackingNumber; }
            set { trackingNumber = value; }
        }
        private DateTime rcvDate;

        public DateTime RcvDate
        {
            get { return rcvDate; }
            set { rcvDate = value; }
        }

        private bool hotPart;

        public bool HotPart
        {
            get { return hotPart; }
            set { hotPart = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private int qty;

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        private string comments;

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public OpenPO()
        {}

        public OpenPO(int custid,string partnumber,DateTime receivedate,string ponum)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["AFI.Properties.Settings.Database1ConnectionString"].ConnectionString;

                SqlConnection sqlConnection1 = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SPGetRCVPO", sqlConnection1);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@CUSTOMERID", SqlDbType.Int).Value = custid;
                command.Parameters.Add("@PARTNUMBER", SqlDbType.VarChar).Value = partnumber;
                command.Parameters.Add("@PONUMBER", SqlDbType.VarChar).Value = ponum;
                command.Parameters.Add("@RECEIVEDATE", SqlDbType.DateTime).Value = receivedate;
                sqlConnection1.Open();
  
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    PoNumber = reader["PONUMBER"].ToString();
                    TrackingNumber = reader["TRACKINGNUMBER"].ToString();
                    RcvDate = DateTime.Parse(reader["RECEIVEDATE"].ToString());
                    if (reader["HOTPART"].ToString().ToUpper() == "Y")
                    {
                        HotPart = true;
                    }
                    else
                    {
                        HotPart = false;
                    }
                    Color = reader["COLOR"].ToString();
                    Qty = int.Parse(reader["INITIALQTY"].ToString());
                    Comments = reader["COMMENTS"].ToString();
                }
                reader.Close();

                // Data is accessible through the DataReader object here.
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                string s = ex.Message;  
            }
        }
    }
}
