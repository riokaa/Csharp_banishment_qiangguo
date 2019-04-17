using BanishmentImageDll;
using System.Windows.Forms;

namespace Banishment {
    public partial class WebForm : Form {
        public WebForm() {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI() {
            this.Icon = Src.GetIcon("MainIcon");
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
