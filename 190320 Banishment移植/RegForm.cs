using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banishment {
    public partial class RegForm : Form {
        public RegForm() {
            InitializeComponent();
        }

        private void InitializeUI() {
            this.RegSplitter.SplitterDistance = (int)(this.RegSplitter.Height * 0.33);
        }
    }
}
