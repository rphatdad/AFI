using System;
using System.Collections.Generic;
using System.Text;

namespace AFIObjects
{
    public class RouterRptObj
    {
        private List<Part> m_plist;
        private List<PartMaskLink> m_mplinklist;
        private String customer;

        public String Customer
        {
            get { return customer; }
            set { customer = value; }
        }


        public RouterRptObj(Part p, List<PartMaskLink> l, String Cust)
        {
            m_plist = new List<Part>();
            m_plist.Add(p);
            m_mplinklist = l;
            customer = Cust;
        }

        public List<Part> GetParts()
        {
            return m_plist;
        }
        public List<PartMaskLink> GetMasks()
        {
            return m_mplinklist;
        }

    }
}
