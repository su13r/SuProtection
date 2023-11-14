using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuPassword
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, this.Width, this.Height, 24, 24));
            AddBtn.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, AddBtn.Width, AddBtn.Height, 8, 8));
            AccName.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, AccName.Width, AccName.Height, 8, 8));
            AccMail.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, AccMail.Width, AccMail.Height, 8, 8));
            AccPass.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, AccPass.Width, AccPass.Height, 8, 8));
            AccLink.Region = Region.FromHrgn(Main.Style.CreateRoundRectRgn(0, 0, AccLink.Width, AccLink.Height, 8, 8));

        }

        private void ExitDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            var sqlite = new SQLiteConnection(@"Data Source=" + Accounts.DB_PATH);
            sqlite.Open();
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO Accounts (email , password , name , url) VALUES " +
                "('" + AccMail.Text + "','" + Cipher.Encrypt(Main.MAIN_KEY, AccPass.Text) + "','" +
                AccName.Text + "','" + AccLink.Text + "')", sqlite);
            insertSQL.ExecuteNonQuery();
            Accounts.Instance.ShowAccounts();
            this.Close();
        }
    }
}
