using System;
using System.Collections.Generic;
using System.Text;

namespace AFIObjects
{
    public class PartMaskLink
    {
        // private members
        int iLinkID;
        string strPartNumber;
        int iPartID;
        string strMaskDescription;
        string strMaskType;
        int iMaskQty;


        // empty constructor
        public PartMaskLink()
        {
        }


        // full constructor
        public PartMaskLink(int LinkID, string PartNumber, int PartID, string MaskDescription, string MaskType,int MaskQty)
        {
            this.iLinkID = LinkID;
            this.strPartNumber = PartNumber;
            this.iPartID = PartID;
            this.strMaskDescription = MaskDescription;
            this.strMaskType = MaskType;
            this.iMaskQty = MaskQty;
        }

        // public accessors
        public int LinkID
        {
            get { return iLinkID; }
            set { iLinkID = value; }
        }
        public string PartNumber
        {
            get { return strPartNumber; }
            set { strPartNumber = value; }
        }
        public int PartID
        {
            get { return iPartID; }
            set { iPartID = value; }
        }
        public string MaskDescription
        {
            get { return strMaskDescription; }
            set { strMaskDescription = value; }
        }
        public string MaskType
        {
            get { return strMaskType; }
            set { strMaskType = value; }
        }
        public int MaskQty
        {
            get { return iMaskQty; }
            set { iMaskQty = value; }
        }
    }
}
