using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuPassword
{
    public partial class SUPT : Form
    {
        public SUPT(String path)
        {
            InitializeComponent();

            if (path != "none" )
            {
               infoLabel.Text = path;
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(ofd.FileName);
                    if (file.Length > 2147483648)
                    {
                        MessageBox.Show("File size too much ... ");
                        return;
                    }
                    infoLabel.Text = ofd.FileName;
                }
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Password.Text)) { MessageBox.Show("Write Password."); return; }
            if (String.IsNullOrEmpty(infoLabel.Text)) { MessageBox.Show("Select File"); return; }
            using (SaveFileDialog OP = new SaveFileDialog())
            {
                var type = Path.GetExtension(infoLabel.Text);
                if (OP.ShowDialog() == DialogResult.OK)
                {

                    new Thread(delegate () {
                        Invoke((MethodInvoker)delegate {
                            loading.Visible = true;
                        });
                        try
                        {
                            Cipher.file_encrypt(infoLabel.Text, OP.FileName + type + ".supt", Password.Text, "XYZZ");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error");
                        }
                        Invoke((MethodInvoker)delegate {
                            loading.Visible = false;
                        });
                    }).Start();
                }
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Password.Text)) { MessageBox.Show("Write Password."); return; }
            if (String.IsNullOrEmpty(infoLabel.Text)) { MessageBox.Show("Select File"); return; }
            using (SaveFileDialog OP = new SaveFileDialog())
            {
                if (OP.ShowDialog() == DialogResult.OK)
                {
                    var x = infoLabel.Text.Split(new string[] { ".supt" }, StringSplitOptions.None);
                    var type = Path.GetExtension(x[0]);
                    new Thread(delegate () {

                        Invoke((MethodInvoker)delegate {
                            loading.Visible = true;
                        });
                        try
                        {
                            Cipher.file_decrypt(infoLabel.Text, OP.FileName + type, Password.Text, "XYZZ");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error ,check password");
                        }
                        Invoke((MethodInvoker)delegate {
                            loading.Visible = false;
                        });

                    }).Start();
                }
            }
        }
    }
}
