using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuPassword
{
    public partial class Accounts : UserControl
    {
        public static string DB_PATH = Application.CommonAppDataPath + @"\System.Windws.Forms.dll";
        public static Accounts Instance;
        public Accounts()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            Instance = this;
            CheckDataBase();
            ShowAccounts();
        }

        public void ShowAccounts()
        {
            AccountsLiv.Items.Clear();
            using (var sql_con = new SQLiteConnection(@"Data Source=" + DB_PATH))
            {
                sql_con.Open();
                SQLiteCommand sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = "SELECT * FROM Accounts";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con);
                DataTable DS = new DataTable();
                DB.Fill(DS);
                foreach (DataRow row in DS.Rows)
                {
                    var stringArr = row.ItemArray.Select(x => x.ToString()).ToArray();
                    ListViewItem lvi = new ListViewItem(stringArr);
                    AccountsLiv.Items.Add(lvi);
                }
            }
            foreach (ListViewItem item in AccountsLiv.Items)
            {
                item.SubItems[2].Text = Cipher.Decrypt( Main.MAIN_KEY, item.SubItems[2].Text);
            }
        }
        void CheckDataBase()
        {
            if (!System.IO.File.Exists(DB_PATH))
            {
                SQLiteConnection.CreateFile(DB_PATH);

                using (var sqlite = new SQLiteConnection(@"Data Source=" + DB_PATH))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE Accounts (id INTEGER PRIMARY KEY AUTOINCREMENT,email TEXT NOT NULL,password TEXT,name TEXT,url TEXT); ";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.ShowDialog();
        }

        private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccountsLiv.SelectedItems.Count != 0)
            {

                string x = AccountsLiv.SelectedItems[0].SubItems[2].Text;
                if(x .Length > 0) { Clipboard.SetText(x); }
                
            }
        }

        private void copyEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccountsLiv.SelectedItems.Count != 0)
            {

                string x = AccountsLiv.SelectedItems[0].SubItems[1].Text;
                Clipboard.SetText(x);
            }
        }
        public static string deleteStatus = "no";
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AccountsLiv.SelectedItems.Count != 0)
            {
                string id = AccountsLiv.SelectedItems[0].SubItems[0].Text;

                DeleteConfirm deleteConfirm = new DeleteConfirm();
                deleteConfirm.ShowDialog();
                if (deleteStatus == "yes") {
                    using (var sqlite2 = new SQLiteConnection(@"Data Source=" + DB_PATH))
                    {
                        sqlite2.Open();
                        string sql = "DELETE FROM Accounts WHERE id = '" + id + "';";
                        SQLiteCommand command = new SQLiteCommand(sql, sqlite2);
                        command.ExecuteNonQuery();
                        ShowAccounts();
                    }
                }
            }
        }
    }
}
