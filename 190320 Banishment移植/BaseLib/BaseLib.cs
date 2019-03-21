using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190320_Banishment移植.BaseLib {
    class BaseLib {
        public static string getCurrentTime() {
            return DateTime.Now.ToLocalTime().ToString();
        }
    }
}
