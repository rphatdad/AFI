namespace AFIObjects
{
    using System;

    public class PO
    {
        // private members
        int iId;
        string strPoNumber;
        int iCustomerID;
        string strPartNumber;
        string strTrackingNumber;
        DateTime dtReceiveDate;
        string strHotPart;
        string strColor;
        string strComments;
        int iInitialQty;
        int iOnHandQty;
        int iInventoryQty;
        int iFabRejectQty;
        int iPaintRejectQty;
        int iShipQty;
        string strPOStatus;
        string strRcvComment;
        string strInvComment;
        string strShipComment;
        int iShipTo;
        int iBillTo;
        DateTime? dtCloseDate;
        DateTime? dtLastShipDate;
        int iDaysAtAFI;

        // empty constructor
        public PO()
        {
        }

        // RCV Constructor
        public PO(string PoNumber, int CustomerID, string PartNumber, string TrackingNumber,
                  DateTime ReceiveDate, string HotPart, string Color, int InitialQty, string RcvComment)
        {
            this.iId = 0;
            this.strPoNumber = PoNumber;
            this.iCustomerID = CustomerID;
            this.strPartNumber = PartNumber;
            this.strTrackingNumber = TrackingNumber;
            this.dtReceiveDate = ReceiveDate;
            this.strHotPart = HotPart;
            this.strColor = Color;
            this.strComments = "";
            this.iInitialQty = InitialQty;
            this.iOnHandQty = InitialQty;
            this.iInventoryQty = 0;
            this.iFabRejectQty = 0;
            this.iPaintRejectQty = 0;
            this.strPOStatus = "OPEN";
            this.strRcvComment = RcvComment;
            this.strInvComment = "";
            this.strShipComment = "";
            this.iShipTo = 0;
            this.iBillTo = 0;
            this.iShipQty = 0;
            this.iDaysAtAFI = 0;
        }
        // full constructor
        public PO(int Id, string PoNumber, int CustomerID, string PartNumber, string TrackingNumber, DateTime ReceiveDate, 
                  string HotPart, string Color, string Comments, int InitialQty, int OnHandQty, int InventoryQty, 
                  int FabRejectQty, int PaintRejectQty,int ShipQty, string POStatus, string RcvComment, string InvComment, 
                  string ShipComment, int ShipTo, int BillTo, DateTime CloseDate,DateTime LastShipDate, int DaysAtAFI)
        {
            this.iId = Id;
            this.strPoNumber = PoNumber;
            this.iCustomerID = CustomerID;
            this.strPartNumber = PartNumber;
            this.strTrackingNumber = TrackingNumber;
            this.dtReceiveDate = ReceiveDate;
            this.strHotPart = HotPart;
            this.strColor = Color;
            this.strComments = Comments;
            this.iInitialQty = InitialQty;
            this.iOnHandQty = OnHandQty;
            this.iInventoryQty = InventoryQty;
            this.iFabRejectQty = FabRejectQty;
            this.iShipQty = ShipQty;
            this.iPaintRejectQty = PaintRejectQty;
            this.strPOStatus = POStatus;
            this.strRcvComment = RcvComment;
            this.strInvComment = InvComment;
            this.strShipComment = ShipComment;
            this.iShipTo = ShipTo;
            this.iBillTo = BillTo;
            this.dtCloseDate = CloseDate;
            this.dtLastShipDate = LastShipDate;
            this.iDaysAtAFI = DaysAtAFI;
        }

        // public accessors
        public int Id
        {
            get { return iId; }
            set { iId = value; }
        }
        public string PoNumber
        {
            get { return strPoNumber; }
            set { strPoNumber = value; }
        }
        public int CustomerID
        {
            get { return iCustomerID; }
            set { iCustomerID = value; }
        }
        public string PartNumber
        {
            get { return strPartNumber; }
            set { strPartNumber = value; }
        }
        public string TrackingNumber
        {
            get { return strTrackingNumber; }
            set { strTrackingNumber = value; }
        }
        public DateTime ReceiveDate
        {
            get { return dtReceiveDate; }
            set { dtReceiveDate = value; }
        }
        public string HotPart
        {
            get { return strHotPart; }
            set { strHotPart = value; }
        }
        public string Color
        {
            get { return strColor; }
            set { strColor = value; }
        }
        public string Comments
        {
            get { return strComments; }
            set { strComments = value; }
        }
        public int InitialQty
        {
            get { return iInitialQty; }
            set { iInitialQty = value; }
        }
        public int OnHandQty
        {
            get { return iOnHandQty; }
            set { iOnHandQty = value; }
        }
        public int InventoryQty
        {
            get { return iInventoryQty; }
            set { iInventoryQty = value; }
        }
        public int FabRejectQty
        {
            get { return iFabRejectQty; }
            set { iFabRejectQty = value; }
        }
        public int PaintRejectQty
        {
            get { return iPaintRejectQty; }
            set { iPaintRejectQty = value; }
        }
        public string POStatus
        {
            get { return strPOStatus; }
            set { strPOStatus = value; }
        }
        public string RcvComment
        {
            get { return strRcvComment; }
            set { strRcvComment = value; }
        }
        public string InvComment
        {
            get { return strInvComment; }
            set { strInvComment = value; }
        }
        public string ShipComment
        {
            get { return strShipComment; }
            set { strShipComment = value; }
        }
        public int ShipTo
        {
            get { return iShipTo; }
            set { iShipTo = value; }
        }
        public int ShippedQty
        {
            get { return iShipQty; }
            set { iShipQty = value; }
        }
        public int BillTo
        {
            get { return iBillTo; }
            set { iBillTo = value; }
        }
        public DateTime? CloseDate
        {
            get { return dtCloseDate; }
            set { dtCloseDate = value; }
        }
        public DateTime? LastShipDate
        {
            get { return dtLastShipDate; }
            set { dtLastShipDate = value; }
        }

        public int DaysAtAFI
        {
            get { return iDaysAtAFI; }
            set { iDaysAtAFI = value; }
        }

        public int GetDaysatAFI()
        {
            TimeSpan ts = new TimeSpan();
            if (this.CloseDate == null)
            {
                ts = DateTime.Now - this.ReceiveDate;
            }
            else
            {
                ts = (DateTime) this.CloseDate - (DateTime) this.ReceiveDate;
            }
            return ts.Days;
        }

    }
}

