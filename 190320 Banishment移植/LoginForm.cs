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
    public partial class LoginForm : Form {
        public TextBox TextUser;
        public TextBox TextPwd;

        public LoginForm() {
            InitializeComponent();
            InitializeUI();
        }
        /// <summary>
        /// 界面初始化
        /// </summary>
        private void InitializeUI() {
            TextUser = new TextBox() {
                Dock = DockStyle.Fill,
            };
            TextPwd = new TextBox() {
                Dock = DockStyle.Fill,
                UseSystemPasswordChar = true,
            };
            LoginTable.Controls.Add(new Label() {
                Dock = DockStyle.Fill,
                Text = "用户名：",
                TextAlign = ContentAlignment.MiddleRight,
            }, 0, 0);
            LoginTable.Controls.Add(new Label() {
                Dock = DockStyle.Fill,
                Text = "密码：",
                TextAlign = ContentAlignment.MiddleRight,
            }, 0, 1);
            LoginTable.Controls.Add(TextUser, 1, 0);
            LoginTable.Controls.Add(TextPwd, 1, 1);
        }
    }
}
