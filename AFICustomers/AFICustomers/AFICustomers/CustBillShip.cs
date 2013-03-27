using System;
using System.Collections.Generic;
using System.Text;


namespace AFICustomers
    {
        public class CustBillShip
        {
            // private members
            int iID;
            string strAddressName;
            string strAddressType;
            string strAddress1;
            string strAddress2;
            string strCity;
            string strState;
            string strZip;
            int iCustomerID;


            // empty constructor
            public CustBillShip()
            {
            }


            // full constructor
            public CustBillShip(int ID, string AddressName, string AddressType, string Address1, string Address2, string City, string State, string Zip, int CustomerID)
            {
                this.iID = ID;
                this.strAddressName = AddressName;
                this.strAddressType = AddressType;
                this.strAddress1 = Address1;
                this.strAddress2 = Address2;
                this.strCity = City;
                this.strState = State;
                this.strZip = Zip;
                this.iCustomerID = CustomerID;
            }

            // partial constructor
            public CustBillShip(int CustomerID)
            {
                
                this.strAddressName = "";
                this.strAddressType = "";
                this.strAddress1 = "";
                this.strAddress2 = "";
                this.strCity = "";
                this.strState = "";
                this.strZip = "";
                this.iCustomerID = CustomerID;
            }

            // public accessors
            public int ID
            {
                get { return iID; }
                set { iID = value; }
            }
            public string AddressName
            {
                get { return strAddressName; }
                set { strAddressName = value; }
            }
            public string AddressType
            {
                get { return strAddressType; }
                set { strAddressType = value; }
            }
            public string Address1
            {
                get { return strAddress1; }
                set { strAddress1 = value; }
            }
            public string Address2
            {
                get { return strAddress2; }
                set { strAddress2 = value; }
            }
            public string City
            {
                get { return strCity; }
                set { strCity = value; }
            }
            public string State
            {
                get { return strState; }
                set { strState = value; }
            }
            public string Zip
            {
                get { return strZip; }
                set { strZip = value; }
            }
            public int CustomerID
            {
                get { return iCustomerID; }
                set { iCustomerID = value; }
            }


        }
    }
