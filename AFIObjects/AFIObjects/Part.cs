namespace AFIObjects
{
    public class Part
	{
		// private members
		private int iId;
        private string strPartNo;
        private string strPartImage;
        private string strPartDesc;
        private string strColorName;
        private string strPowderNumber;
        private string strHanger;
        private string strRackType;
        private int iCureTemp;
        private int iMillage;
        private int iMinConvSpeed;
        private int iMinPiecesPer;
        private int iFeet;
        private int iMinPartsPerRack;
        private int iKv1;
        private int iFlowRate1;
        private int iAtomizing1;
        private string strReceipe1;
        private int iKv2;
        private int iFlowRate2;
        private int iAtomizing2;
        private string strReceipe2;
        private int iPlugsQty;
        private int iDotsQty;
        private int iCapsQty;
        private string strSpotFace;
        private string strBlowExcessWater;
        private string strSpecialNotes;
        private string strPreMask;
        private double fMaskTime;
        private double fSqFeet;
        private double fPaintTime;
        private double fPoundsPer;


		// empty constructor
		public Part ()
		{
		}

        public Part(string PartNo)
        {
            this.iId = 0;
            this.strPartNo = PartNo;
            this.strPartImage = "";
            this.strPartDesc = "";
            this.strColorName = "";
            this.strPowderNumber = "";
            this.strHanger = "";
            this.strRackType = "";
            this.iCureTemp = 0;
            this.iMillage = 0;
            this.iMinConvSpeed = 0;
            this.iMinPiecesPer = 0;
            this.iFeet = 0;
            this.iMinPartsPerRack = 0;
            this.iKv1 = 0;
            this.iFlowRate1 = 0;
            this.iAtomizing1 = 0;
            this.strReceipe1 = "";
            this.iKv2 = 0;
            this.iFlowRate2 = 0;
            this.iAtomizing2 = 0;
            this.strReceipe2 = "";
            this.iPlugsQty = 0;
            this.iDotsQty = 0;
            this.iCapsQty = 0;
            this.strSpotFace = "";
            this.strBlowExcessWater = "";
            this.strSpecialNotes = "";
            this.strPreMask = "";
            this.fMaskTime = 0.0;
            this.fSqFeet=0.0;
            this.fPaintTime=0.0;

        }
		// full constructor
		public Part (int Id, string PartNo, string PartImage, string PartDesc, string ColorName, string PowderNumber, int CureTemp, int Millage, int MinConvSpeed, int MinPiecesPer, int Feet, int MinPartsPerRack, int Kv1, int FlowRate1, int Atomizing1, string Receipe1, int Kv2, int FlowRate2, int Atomizing2, string Receipe2, int PlugsQty, int DotsQty, int CapsQty, string SpotFace, string BlowExcessWater, string SpecialNotes, string PreMask,float MaskTime,float SqFeet,float PaintTime,float PoundsPer,string Hanger, string Rack)
		{
			this.iId = Id;
			this.strPartNo = PartNo;
			this.strPartImage = PartImage;
			this.strPartDesc = PartDesc;
			this.strColorName = ColorName;
			this.strPowderNumber = PowderNumber;
			this.iCureTemp = CureTemp;
			this.iMillage = Millage;
			this.iMinConvSpeed = MinConvSpeed;
			this.iMinPiecesPer = MinPiecesPer;
			this.iFeet = Feet;
			this.iMinPartsPerRack = MinPartsPerRack;
			this.iKv1 = Kv1;
			this.iFlowRate1 = FlowRate1;
			this.iAtomizing1 = Atomizing1;
			this.strReceipe1 = Receipe1;
			this.iKv2 = Kv2;
			this.iFlowRate2 = FlowRate2;
			this.iAtomizing2 = Atomizing2;
			this.strReceipe2 = Receipe2;
			this.iPlugsQty = PlugsQty;
			this.iDotsQty = DotsQty;
			this.iCapsQty = CapsQty;
			this.strSpotFace = SpotFace;
			this.strBlowExcessWater = BlowExcessWater;
			this.strSpecialNotes = SpecialNotes;
			this.strPreMask = PreMask;
            this.fMaskTime = MaskTime;
            this.fSqFeet = SqFeet;
            this.fPaintTime = PaintTime;
            this.fPoundsPer = PoundsPer;
            this.strRackType = Rack;
            this.strHanger = Hanger;
		}

		// public accessors
		public int Id
		{
			get { return iId;}
			set { iId = value; }
		}
		public string PartNo
		{
			get { return strPartNo;}
			set { strPartNo = value; }
		}
        public string Hanger
        {
            get { return strHanger; }
            set { strHanger = value; }
        }
        public string RackType
        {
            get { return strRackType; }
            set { strRackType = value; }
        }
		public string PartImage
		{
			get { return strPartImage;}
			set { strPartImage = value; }
		}
		public string PartDesc
		{
			get { return strPartDesc;}
			set { strPartDesc = value; }
		}
		public string ColorName
		{
			get { return strColorName;}
			set { strColorName = value; }
		}
		public string PowderNumber
		{
			get { return strPowderNumber;}
			set { strPowderNumber = value; }
		}
		public int CureTemp
		{
			get { return iCureTemp;}
			set { iCureTemp = value; }
		}
		public int Millage
		{
			get { return iMillage;}
			set { iMillage = value; }
		}
		public int MinConvSpeed
		{
			get { return iMinConvSpeed;}
			set { iMinConvSpeed = value; }
		}
		public int MinPiecesPer
		{
			get { return iMinPiecesPer;}
			set { iMinPiecesPer = value; }
		}
		public int Feet
		{
			get { return iFeet;}
			set { iFeet = value; }
		}
		public int MinPartsPerRack
		{
			get { return iMinPartsPerRack;}
			set { iMinPartsPerRack = value; }
		}
		public int Kv1
		{
			get { return iKv1;}
			set { iKv1 = value; }
		}
		public int FlowRate1
		{
			get { return iFlowRate1;}
			set { iFlowRate1 = value; }
		}
		public int Atomizing1
		{
			get { return iAtomizing1;}
			set { iAtomizing1 = value; }
		}
		public string Receipe1
		{
			get { return strReceipe1;}
			set { strReceipe1 = value; }
		}
		public int Kv2
		{
			get { return iKv2;}
			set { iKv2 = value; }
		}
		public int FlowRate2
		{
			get { return iFlowRate2;}
			set { iFlowRate2 = value; }
		}
		public int Atomizing2
		{
			get { return iAtomizing2;}
			set { iAtomizing2 = value; }
		}
		public string Receipe2
		{
			get { return strReceipe2;}
			set { strReceipe2 = value; }
		}
		public int PlugsQty
		{
			get { return iPlugsQty;}
			set { iPlugsQty = value; }
		}
		public int DotsQty
		{
			get { return iDotsQty;}
			set { iDotsQty = value; }
		}
		public int CapsQty
		{
			get { return iCapsQty;}
			set { iCapsQty = value; }
		}
		public string SpotFace
		{
			get { return strSpotFace;}
			set { strSpotFace = value; }
		}
		public string BlowExcessWater
		{
			get { return strBlowExcessWater;}
			set { strBlowExcessWater = value; }
		}
		public string SpecialNotes
		{
			get { return strSpecialNotes;}
			set { strSpecialNotes = value; }
		}
		public string PreMask
		{
			get { return strPreMask;}
			set { strPreMask = value; }
		}

        public double MaskTime
        {
            get { return fMaskTime; }
            set { fMaskTime = value; }
        }

        public double SqFeet
        {
            get { return fSqFeet; }
            set { fSqFeet = value; }
        }

        public double PaintTime
        {
            get { return fPaintTime; }
            set { fPaintTime = value; }
        }
        public double PoundsPer
        {
            get { return fPoundsPer; }
            set { fPoundsPer = value; }
        }

    }
}
