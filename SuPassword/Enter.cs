using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuPassword
{
    public partial class Enter : UserControl
    {

        public Enter()
        {
            InitializeComponent();
            Password.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, Password.Width, Password.Height, 8, 8));
            LoginBtn.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, LoginBtn.Width, LoginBtn.Height, 8, 8));

        }
        public Accounts Accounts = new Accounts();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }
        void Login()
        {
            Main.MAIN_KEY = Password.Text;
            Accounts.Dock = DockStyle.Fill;
            Main.Instance.MainPanel.Invoke((MethodInvoker)delegate {
                Main.Instance.MainPanel.Controls.Clear();
                Main.Instance.MainPanel.Controls.Add(Accounts);
            });
        }
        private void GitHubLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/su13r");
        }

        private void TelegramLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/su13r");
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void OpenSUPT_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void OpenSUPT_Click(object sender, EventArgs e)
        {
            SUPT supt = new SUPT("none");
            supt.Show();
        }
    }
}
