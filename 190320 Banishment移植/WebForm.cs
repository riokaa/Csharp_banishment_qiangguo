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
    public partial class WebForm : Form {
        public WebForm() {
            InitializeComponent();
        }
        public void LoadPage(string caption, string url) {
            this.Text = caption;
            this.WebBrowser.Navigate(url);
        }

        private void WebForm_FormClosed(object sender, FormClosedEventArgs e) {
            this.WebBrowser.Dispose();
        }
    }
}
