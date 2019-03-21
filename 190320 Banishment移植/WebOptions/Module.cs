using _190320_Banishment移植.BaseLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190320_Banishment移植.WebOption {
    class Module {

        public void WebGetScore() {
            Log.I("Web get score.");
            MainForm.self.MainWeb.Load(Const.urlQGMyPoints);
        }
    }
}
