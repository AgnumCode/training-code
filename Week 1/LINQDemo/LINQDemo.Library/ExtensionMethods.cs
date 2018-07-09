using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo.Library
{
    public static class ExtensionMethods
    {
        public static bool IsEmpty(this NonGenericCollection col)
        {
<<<<<<< HEAD
            return col.DumbLongest() == null; 
=======
            return col.DumbLongest() == null;
>>>>>>> master
        }
    }
}
