using System;

namespace ValueReferenceExample
{
    public class Element
    {
        private DateTime _createDate;

        public DateTime CreateDate
        {
            get
            {
                return _createDate;
            }

            set
            {
                if(value != new DateTime())
                    _createDate = value;
            }
        }

        public int Code { get; set; }

        public Element()
        {

        }

        public override string ToString()
        {
            return Code.ToString();
        }
    }
}