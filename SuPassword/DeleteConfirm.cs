using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuPassword
{
    public partial class DeleteConfirm : Form
    {
        public DeleteConfirm()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, this.Width, this.Height, 14, 14));
            YesBtn.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, YesBtn.Width, YesBtn.Height, 8, 8));
            NoBtn.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, NoBtn.Width, NoBtn.Height, 8, 8));
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            Accounts.deleteStatus = "yes";
            this.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            Accounts.deleteStatus = "no";
            this.Close();
        }
    }
}
