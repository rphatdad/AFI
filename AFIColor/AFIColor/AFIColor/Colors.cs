using System;

namespace AFIColor
{
    public class Colors
    {
        // private members
        int iId;
        string strColorName;
        string strColorNumber;
        string strColorManufacturer;
        string strAbrev;
        string strPoundsInStock;
        string strDesiredPounds;


        // empty constructor
        public Colors()
        {
        }

        public Colors(string Abrev)
        {
            this.strColorName = "";
            this.strColorNumber = "";
            this.strColorManufacturer = "";
            this.strAbrev = Abrev;
            this.strPoundsInStock = "";
            this.strDesiredPounds = "";
        }

        // full constructor
        public Colors(int Id, string Abrev, string ColorName, string ColorNumber, string ColorManufacturer,  string PoundsInStock, string DesiredPounds)
        {
            this.iId = Id;
            this.strColorName = ColorName;
            this.strColorNumber = ColorNumber;
            this.strColorManufacturer = ColorManufacturer;
            this.strAbrev = Abrev;
            this.strPoundsInStock = PoundsInStock;
            this.strDesiredPounds = DesiredPounds;
        }

        // public accessors
        public int Id
        {
            get { return iId; }
            set { iId = value; }
        }
        public string ColorName
        {
            get { return strColorName; }
            set { strColorName = value; }
        }
        public string ColorNumber
        {
            get { return strColorNumber; }
            set { strColorNumber = value; }
        }
        public string ColorManufacturer
        {
            get { return strColorManufacturer; }
            set { strColorManufacturer = value; }
        }
        public string Abrev
        {
            get { return strAbrev; }
            set { strAbrev = value; }
        }
        public string PoundsInStock
        {
            get { return strPoundsInStock; }
            set { strPoundsInStock = value; }
        }
        public string DesiredPounds
        {
            get { return strDesiredPounds; }
            set { strDesiredPounds = value; }
        }


    }
}
