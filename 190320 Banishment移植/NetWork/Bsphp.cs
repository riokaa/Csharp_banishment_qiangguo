using _190320_Banishment移植.BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190320_Banishment移植.NetWork {
    class Bsphp {

        public static string UpdateSeSSL() {
            BS.sessl = Base.MD5(Base.GetMac() + Base.GetTimeStamp());
            return BS.sessl;
        }
    }
}
