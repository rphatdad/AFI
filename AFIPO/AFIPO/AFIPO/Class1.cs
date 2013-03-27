using System;
using System.Collections.Generic;
using System.Text;

namespace Parts
{
    public class Shippers
    {
        // private members
        int iID;
        string strShipper;
        string strComments;
        string strPhone;
        string strFax;
        string strCell;
        string strOther;


        // empty constructor
        public Shippers()
        {
        }

        public Shippers(string Shipper)
        {
            this.strShipper = Shipper;
        }

        // full constructor
        public Shippers(int ID, string Shipper, string Comments, string Phone, string Fax, string Cell, string Other)
        {
            this.iID = ID;
            this.strShipper = Shipper;
            this.strComments = Comments;
            this.strPhone = Phone;
            this.strFax = Fax;
            this.strCell = Cell;
            this.strOther = Other;
        }

        // public accessors
        public int ID
        {
            get { return iID; }
            set { iID = value; }
        }
        public string Shipper
        {
            get { return strShipper; }
            set { strShipper = value; }
        }
        public string Comments
        {
            get { return strComments; }
            set { strComments = value; }
        }
        public string Phone
        {
            get { return strPhone; }
            set { strPhone = value; }
        }
        public string Fax
        {
            get { return strFax; }
            set { strFax = value; }
        }
        public string Cell
        {
            get { return strCell; }
            set { strCell = value; }
        }
        public string Other
        {
            get { return strOther; }
            set { strOther = value; }
        }


    }
}
