using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.sample
{
    public class Utility
    {
        private string myName=string.Empty;
        private Utility()
        {
        }

        private static Utility _Utility;

        public static Utility UtilityObj
        {
            get
            {
                _Utility = _Utility ?? new Utility();
                return _Utility;
            }
        }

        public delegate void MyDelegate();
        public event MyDelegate OnNotify;

        public void ClickOnNotify()
        {
            if (OnNotify != null)
            {
                OnNotify();
            }
        }
    }
}
