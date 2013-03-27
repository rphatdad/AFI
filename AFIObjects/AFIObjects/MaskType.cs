using System;

namespace AFIObjects
{
	public class MaskType
	{
		// private members
		int iID;
		string strType;
		string strDescription;


		// empty constructor
		public MaskType ()
		{
            this.iID = 0;
		}


		// full constructor
		public MaskType (int ID, string Type, string Description)
		{
			this.iID = ID;
			this.strType = Type;
			this.strDescription = Description;
		}

		// public accessors
		public int ID
		{
			get { return iID;}
			set { iID = value; }
		}
		public string Type
		{
			get { return strType;}
			set { strType = value; }
		}
		public string Description
		{
			get { return strDescription;}
			set { strDescription = value; }
		}


	}
}