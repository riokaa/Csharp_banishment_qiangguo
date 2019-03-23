using _190320_Banishment移植.BaseLib;
using _190320_Banishment移植.NetWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190320_Banishment移植.WebOptions {
    class WebGetVideoList {
        public static void Start() {
            Log.D("WebGetVideoList: getting video list from server.");
            HttpRequest.Get(Const.urlVideoList);
        }
    }
}
