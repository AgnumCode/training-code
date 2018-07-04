using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Library
{
    public class TimeProvider
    {
        //a singleton class meaning only one instance or whatever name

        // a property with just a getter, no setter
        public virtual DateTime CurrentTime => DateTime.Now;

        // or equivalent to
        //public static DateTime currentTime2 {  get { return DateTime.Now; } }

        protected static TimeProvider s_instance;
        protected static TimeProvider s_current;

        public static void ResetToDefaultInstance()
        {
            Current = s_instance;
        }

        public static TimeProvider Current
        {
            get
            {
                if(s_instance == null)
                {
                    s_instance = new TimeProvider();
                }
                if (s_current == null)
                {
                    s_current = s_instance;
                }
                return s_current;
            }

            set
            {
                if(value != null)
                {
                    s_current = value;
                }
            }
        }


        //public static TimeProvider Instance
        //{
        //    get
        //    {
        //        if (s_instance == null)
        //        {
        //            s_instance = new TimeProvider();
        //        }
        //        return s_instance;

        //    }
       
        //}

        protected TimeProvider() { }
    }
}
