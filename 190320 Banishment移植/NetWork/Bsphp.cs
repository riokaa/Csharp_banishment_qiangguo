using Banishment.BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banishment.NetWork {
    class Bsphp {

        public static string UpdateSeSSL() {
            BS.sessl = Base.MD5(BS.machineCode + Base.GetTimeStamp());
            return BS.sessl;
        }
    }
}
